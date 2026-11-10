using System.Buffers.Text;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Dossier;

/// <summary>
/// import of a JSONL bundle. The bundle is untrusted input: only files the manifest lists are read, each
/// is verified against file_stats (bytes, lines, sha256) before anything is committed, lines are read with a
/// length cap, blobs are named only from a validated sha256 (never from a path or file name), and asset files
/// must sit at exactly assets/&lt;sha256&gt;[.ext] inside the bundle with no symbolic links on the way.
/// </summary>
public sealed partial class DossierStore
{
    private const int ImportChunkBytes = 64 * 1024;
    private const long ImportManifestMaxBytes = 64L * 1024 * 1024;

    /// <summary>Default longest line: the largest embeddable asset as base64, plus 1 MiB for the rest of the record.</summary>
    private static long DefaultImportMaxLineBytes => (4 * ((MaxEmbedAssetBytes + 2) / 3)) + (1024 * 1024);

    private sealed class JsonlAsset
    {
        public string Sha = string.Empty;
        public string File = string.Empty;
        public long Line;
        public long Offset;
        public int Length;
        public bool Missing;
        public bool HasData;
        public string? Path;
        public long Bytes;
        public string? Mime;
        public string? DataSha;

        public bool SameRecordAs(JsonlAsset other) =>
            Missing == other.Missing && HasData == other.HasData && Path == other.Path && Bytes == other.Bytes && Mime == other.Mime && DataSha == other.DataSha;
    }

    /// <summary>The manifest's "format" when it is a string (a JSONL bundle); null for markdown bundles (number or absent) and unreadable manifests.</summary>
    private static string? ReadBundleFormat(string root)
    {
        var path = Path.Combine(root, BundleManifest);
        var info = new FileInfo(path);
        if (IsLink(info))
        {
            throw new DossierRequestException("import_unsafe_path", "manifest.json is a symbolic link; refusing to read it");
        }

        if (!info.Exists || info.Length > ImportManifestMaxBytes)
        {
            return null;
        }

        try
        {
            using var document = ReadManifestDocument(path);
            return document.RootElement.ValueKind == JsonValueKind.Object
                && document.RootElement.TryGetProperty("format", out var format)
                && format.ValueKind == JsonValueKind.String
                    ? format.GetString()
                    : null;
        }
        catch (JsonException)
        {
            return null;
        }
    }

    private static bool IsLink(FileSystemInfo info) => info.LinkTarget is not null || (info.Attributes & FileAttributes.ReparsePoint) != 0;

    private static partial class Posix
    {
        [LibraryImport("libc", EntryPoint = "open", StringMarshalling = StringMarshalling.Utf8, SetLastError = true)]
        internal static partial int Open(string path, int flags);
    }

    /// <summary>
    /// Opens <paramref name="path"/> for reading only when it is a regular file. No managed API tells a named pipe
    /// or device from a regular file without opening it, and opening a FIFO blocks, so on Unix the file is opened
    /// non-blocking and must be seekable: pipes, sockets and ttys are not. The caller has already rejected links.
    /// </summary>
    /// <summary>
    /// open(2) flags O_RDONLY (0) | O_NONBLOCK | O_NOFOLLOW | O_CLOEXEC for a known (OS, architecture) pair; anything else
    /// fails closed instead of guessing, because a wrong bit here silently opens FIFOs blocking or follows links.
    /// Values per each OS's &lt;fcntl.h&gt;: Linux O_NONBLOCK 0x800 and O_CLOEXEC 0x80000 everywhere, O_NOFOLLOW 0x20000 on the
    /// x86 and generic-asm architectures listed and 0x8000 on arm, arm64 and powerpc.
    /// </summary>
    internal static int UnixOpenFlags(string os, Architecture architecture) => (os, architecture) switch
    {
        ("macos", _) => 0x4 | 0x100 | 0x1000000,
        ("freebsd", _) => 0x4 | 0x100 | 0x100000,
        ("linux", Architecture.X64 or Architecture.X86 or Architecture.RiscV64 or Architecture.LoongArch64 or Architecture.S390x) => 0x800 | 0x20000 | 0x80000,
        ("linux", Architecture.Arm64 or Architecture.Arm or Architecture.Armv6 or Architecture.Ppc64le) => 0x800 | 0x8000 | 0x80000,
        _ => throw new DossierRequestException("import_unsupported_platform", $"opening bundle files safely is not supported on {os}/{architecture}"),
    };

    internal static FileStream OpenRegularFile(string path, string label, int bufferSize)
    {
        if (OperatingSystem.IsWindows())
        {
            return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize, FileOptions.SequentialScan);
        }

        var flags = UnixOpenFlags(OperatingSystem.IsMacOS() ? "macos" : OperatingSystem.IsFreeBSD() ? "freebsd" : OperatingSystem.IsLinux() || OperatingSystem.IsAndroid() ? "linux" : "other", RuntimeInformation.ProcessArchitecture);

        var fd = Posix.Open(path, flags);
        if (fd < 0)
        {
            var errno = Marshal.GetLastPInvokeError();
            var eloop = OperatingSystem.IsLinux() ? 40 : 62;
            throw errno switch
            {
                2 or 20 => new DossierRequestException("import_file_missing", $"{label} is not in the bundle (errno {errno})"),
                _ when errno == eloop || errno == 31 => new DossierRequestException("import_unsafe_path", $"{label} is a symbolic link; refusing to read it (errno {errno})"),
                1 or 13 => new DossierRequestException("import_unreadable_file", $"{label} could not be read: permission denied (errno {errno})"),
                _ => new DossierRequestException("import_not_regular_file", $"{label} could not be opened as a regular file (errno {errno})"),
            };
        }

        var handle = new SafeFileHandle((IntPtr)fd, ownsHandle: true);
        try
        {
            var stream = new FileStream(handle, FileAccess.Read, bufferSize, isAsync: false);
            if (!stream.CanSeek)
            {
                stream.Dispose();
                throw new DossierRequestException("import_not_regular_file", $"{label} is not a regular file (a named pipe, socket or device); refusing to read it");
            }

            return stream;
        }
        catch (UnauthorizedAccessException)
        {
            handle.Dispose();
            throw new DossierRequestException("import_not_regular_file", $"{label} is not a regular file (a directory or device); refusing to read it");
        }
        catch
        {
            handle.Dispose();
            throw;
        }
    }

    /// <summary>
    /// Reads at most <paramref name="limit"/> bytes of <paramref name="input"/>, never until EOF: when one more byte is
    /// still available the stream is longer than promised and <c>null</c> is returned. A seekable device that reports
    /// Length 0 (/dev/zero) therefore yields an empty buffer or null, never an unbounded read.
    /// </summary>
    internal static byte[]? ReadAtMost(Stream input, long limit)
    {
        var buffer = new byte[(int)Math.Min(limit, Array.MaxLength)];
        var filled = 0;
        while (filled < buffer.Length)
        {
            var read = input.Read(buffer, filled, buffer.Length - filled);
            if (read <= 0)
            {
                Array.Resize(ref buffer, filled);
                return buffer;
            }

            filled += read;
        }

        return input.ReadByte() >= 0 ? null : buffer;
    }

    /// <summary>Copies at most <paramref name="limit"/> bytes to <paramref name="output"/> and the hash; false when more data was still available.</summary>
    /// <summary>How many bytes of an asset file to copy: the declared size, never more than the opened handle says it holds (a negative declaration means "unknown").</summary>
    internal static long AssetCopyLimit(long declared, long handleLength) => Math.Min(declared >= 0 ? declared : long.MaxValue, handleLength);

    internal static bool CopyAtMost(Stream input, Stream output, IncrementalHash hash, long limit)
    {
        var chunk = new byte[ImportChunkBytes];
        long copied = 0;
        while (copied < limit)
        {
            var read = input.Read(chunk, 0, (int)Math.Min(chunk.Length, limit - copied));
            if (read <= 0)
            {
                return true;
            }

            hash.AppendData(chunk, 0, read);
            output.Write(chunk, 0, read);
            copied += read;
        }

        return input.ReadByte() < 0;
    }

    /// <summary>Parses manifest.json after reading at most min(handle length, 64 MiB) bytes of it.</summary>
    private static JsonDocument ReadManifestDocument(string path)
    {
        using var stream = OpenRegularFile(path, BundleManifest, 4096);
        var bytes = ReadAtMost(stream, Math.Min(stream.Length, ImportManifestMaxBytes));
        if (bytes is null)
        {
            throw new DossierRequestException("import_unsafe_path", "manifest.json is too large to read, or longer than its file size says");
        }

        return JsonDocument.Parse(bytes);
    }

    private ImportResult ImportJsonl(string root, ImportOptions options)
    {
        var maxLine = options.MaxLineBytes > 0 ? options.MaxLineBytes : DefaultImportMaxLineBytes;

        // ---- manifest ----
        var manifestInfo = new FileInfo(Path.Combine(root, BundleManifest));
        if (IsLink(manifestInfo) || manifestInfo.Length > ImportManifestMaxBytes)
        {
            throw new DossierRequestException("import_unsafe_path", "manifest.json is a symbolic link or too large to read");
        }

        JsonDocument manifest;
        try
        {
            manifest = ReadManifestDocument(manifestInfo.FullName);
        }
        catch (JsonException exception)
        {
            throw new DossierRequestException("import_bad_manifest", "manifest.json is not valid JSON: " + exception.Message);
        }

        using (manifest)
        {
            var manifestRoot = manifest.RootElement;
            if (manifestRoot.ValueKind != JsonValueKind.Object
                || !manifestRoot.TryGetProperty("files", out var filesElement) || filesElement.ValueKind != JsonValueKind.Array
                || !manifestRoot.TryGetProperty("file_stats", out var statsElement) || statsElement.ValueKind != JsonValueKind.Object)
            {
                throw new DossierRequestException("import_bad_manifest", "manifest.json lacks the \"files\" array or the \"file_stats\" object");
            }

            var dataFiles = new List<string>();
            var fileNumbers = new Dictionary<string, long>(StringComparer.Ordinal);
            var usedNumbers = new HashSet<long>();
            var listedAssets = new HashSet<string>(StringComparer.Ordinal);
            foreach (var entry in filesElement.EnumerateArray())
            {
                var name = entry.ValueKind == JsonValueKind.String ? entry.GetString()! : string.Empty;
                if (name == BundleManifest)
                {
                    continue;
                }

                if (JsonlDataFileRegex.IsMatch(name))
                {
                    if (!long.TryParse(name.AsSpan(8, name.Length - 14), NumberStyles.None, CultureInfo.InvariantCulture, out var number))
                    {
                        throw new DossierRequestException("import_bad_manifest", $"manifest.json lists {name}, whose file number is too large");
                    }

                    if (fileNumbers.ContainsKey(name) || !usedNumbers.Add(number))
                    {
                        throw new DossierRequestException("import_bad_manifest", $"manifest.json lists {name} more than once (or two names with the same file number)");
                    }

                    fileNumbers[name] = number;
                    dataFiles.Add(name);
                }
                else if (JsonlAssetPathRegex.IsMatch(name))
                {
                    if (!listedAssets.Add(name))
                    {
                        throw new DossierRequestException("import_bad_manifest", $"manifest.json lists {name} more than once");
                    }
                }
                else
                {
                    throw new DossierRequestException("import_unlisted_file", $"manifest.json lists \"{name}\", which is not a file name a JSONL bundle can contain; refusing to read it");
                }
            }

            var listedData = dataFiles.ToHashSet(StringComparer.Ordinal);
            foreach (var onDisk in Directory.EnumerateFiles(root, "dossier-*.jsonl", SearchOption.TopDirectoryOnly).Select(p => Path.GetFileName(p)))
            {
                if (JsonlDataFileRegex.IsMatch(onDisk) && !listedData.Contains(onDisk))
                {
                    throw new DossierRequestException("import_unlisted_file", $"{onDisk} is in the bundle directory but not listed in manifest.json; refusing to import a partly listed bundle");
                }
            }

            var hiddenSkips = RejectUnlistedAssets(root, listedAssets);

            var stats = new Dictionary<string, (long Bytes, long Lines, string Sha)>(StringComparer.Ordinal);
            foreach (var property in statsElement.EnumerateObject())
            {
                if (!listedData.Contains(property.Name))
                {
                    throw new DossierRequestException("import_file_mismatch", $"file_stats describes {property.Name}, which manifest.json does not list as a data file");
                }

                var value = property.Value;
                if (value.ValueKind != JsonValueKind.Object
                    || !value.TryGetProperty("bytes", out var bytesElement) || !bytesElement.TryGetInt64(out var bytes) || bytes < 0
                    || !value.TryGetProperty("lines", out var linesElement) || !linesElement.TryGetInt64(out var lines) || lines < 0
                    || !value.TryGetProperty("sha256", out var shaElement) || shaElement.ValueKind != JsonValueKind.String || !Sha256Hex.IsMatch(shaElement.GetString()!))
                {
                    throw new DossierRequestException("import_file_mismatch", $"file_stats for {property.Name} lacks bytes, lines or a 64-character lowercase sha256");
                }

                stats[property.Name] = (bytes, lines, shaElement.GetString()!);
            }

            foreach (var name in dataFiles)
            {
                if (!stats.ContainsKey(name))
                {
                    throw new DossierRequestException("import_file_mismatch", $"manifest.json lists {name} but file_stats has no bytes/lines/sha256 for it");
                }
            }

            // ---- pass 1: verify every data file as it is read; collect subjects, facts and asset locations ----
            var subjects = new Dictionary<string, ImportSubject>(StringComparer.Ordinal);
            var records = new List<ImportRecord>();
            var byId = new Dictionary<string, ImportRecord>(StringComparer.Ordinal);
            var assets = new Dictionary<string, JsonlAsset>(StringComparer.Ordinal);
            var result = new ImportResult();
            result.Skipped.AddRange(hiddenSkips);
            long order = 0;

            foreach (var name in dataFiles.OrderBy(n => fileNumbers[n]))
            {
                ReadJsonlFile(root, name, stats[name], maxLine, (lineNumber, offset, line) =>
                {
                    var where = $"{name}:{lineNumber.ToString(CultureInfo.InvariantCulture)}";
                    if (line.Length == 0)
                    {
                        throw new DossierRequestException("import_bad_record", $"{where} is an empty line");
                    }

                    JsonDocument document;
                    try
                    {
                        document = JsonDocument.Parse(line);
                    }
                    catch (JsonException exception)
                    {
                        throw new DossierRequestException("import_bad_record", $"{where} is not valid JSON: {exception.Message}");
                    }

                    using (document)
                    {
                        var e = document.RootElement;
                        if (e.ValueKind != JsonValueKind.Object || !e.TryGetProperty("type", out var typeElement) || typeElement.ValueKind != JsonValueKind.String)
                        {
                            throw new DossierRequestException("import_bad_record", $"{where} is not a JSON object with a string \"type\"");
                        }

                        string? Str(string property) => e.TryGetProperty(property, out var v) && v.ValueKind == JsonValueKind.String ? v.GetString() : null;
                        var type = typeElement.GetString()!;
                        switch (type)
                        {
                            case "subject":
                            {
                                var id = Str("id");
                                var subjectName = Str("name");
                                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(subjectName))
                                {
                                    result.Skipped.Add(new ImportSkip(where, "subject line lacks id or name"));
                                    return;
                                }

                                if (subjects.ContainsKey(id))
                                {
                                    throw new DossierRequestException("import_duplicate_id", $"subject id {id} appears twice (second at {where})");
                                }

                                var aliases = e.TryGetProperty("aliases", out var a) && a.ValueKind == JsonValueKind.Array
                                    ? a.EnumerateArray().Where(x => x.ValueKind == JsonValueKind.String).Select(x => x.GetString()!).ToList()
                                    : new List<string>();
                                string? pin = e.TryGetProperty("pin", out var p) && p.ValueKind == JsonValueKind.Object ? CanonicalJson.Write(p) : null;
                                subjects[id] = new ImportSubject(id, subjectName, Str("kind") ?? "subject", Str("parent"), aliases, pin);
                                return;
                            }

                            case "fact":
                            {
                                var (record, error) = ParseImportRecordElement(where, string.Empty, e);
                                if (record is null)
                                {
                                    result.Skipped.Add(new ImportSkip(where, error!.Replace("machine record", "fact line", StringComparison.Ordinal)));
                                    return;
                                }

                                if (byId.TryGetValue(record.Id, out var first))
                                {
                                    throw new DossierRequestException("import_duplicate_id", $"fact id {record.Id} is claimed by two fact lines: {first.Path} and {where}");
                                }

                                record.Order = order++;
                                byId[record.Id] = record;
                                records.Add(record);
                                return;
                            }

                            case "asset":
                            {
                                var sha = Str("sha256");
                                if (sha is null)
                                {
                                    result.Skipped.Add(new ImportSkip(where, "asset line lacks sha256"));
                                    return;
                                }

                                var candidate = new JsonlAsset
                                {
                                    Sha = sha,
                                    File = name,
                                    Line = lineNumber,
                                    Offset = offset,
                                    Length = line.Length,
                                    Missing = e.TryGetProperty("missing", out var m) && m.ValueKind == JsonValueKind.True,
                                    HasData = e.TryGetProperty("data", out var d) && d.ValueKind == JsonValueKind.String,
                                    Path = Str("path"),
                                    Bytes = e.TryGetProperty("bytes", out var b) && b.ValueKind == JsonValueKind.Number && b.TryGetInt64(out var n) ? n : -1,
                                    Mime = Str("mime"),
                                    // Hash the raw UTF-8 token straight out of the parsed line: no UTF-16 string, no re-encoding. An escaped and an
                                    // unescaped spelling of the same data compare unequal, which fails closed.
                                    DataSha = d.ValueKind == JsonValueKind.String ? Convert.ToHexString(SHA256.HashData(JsonMarshal.GetRawUtf8Value(d))) : null,
                                };
                                if (!assets.TryGetValue(sha, out var firstAsset))
                                {
                                    assets[sha] = candidate;
                                }
                                else if (!firstAsset.SameRecordAs(candidate))
                                {
                                    throw new DossierRequestException(
                                        "import_bad_record",
                                        $"{where} repeats asset {sha} with a different path, bytes, mime, data or missing flag than its first record at {firstAsset.File}:{firstAsset.Line}");
                                }

                                return;
                            }

                            default:
                                result.Skipped.Add(new ImportSkip(where, $"unknown record type \"{type}\"; not imported"));
                                return;
                        }
                    }
                });
            }

            if (records.Count == 0)
            {
                throw new DossierRequestException("bundle_has_no_records", "the JSONL bundle holds no readable fact lines");
            }

            foreach (var record in records)
            {
                if (!subjects.ContainsKey(record.SubjectId))
                {
                    subjects[record.SubjectId] = new ImportSubject(record.SubjectId, record.SubjectName, "subject", null, new List<string>(), null);
                }
            }

            // ---- pass 2: blobs, one asset at a time, only for attachments a fact cites ----
            var done = new Dictionary<string, (bool Restored, string Reason)>(StringComparer.Ordinal);
            return CommitImport(
                result,
                records,
                subjects,
                (record, attachment) =>
                {
                    if (done.TryGetValue(attachment.Sha256, out var known))
                    {
                        return known;
                    }

                    var outcome = RestoreJsonlBlob(root, attachment.Sha256, assets, listedAssets);
                    done[attachment.Sha256] = outcome;
                    return outcome;
                });
        }
    }

    /// <summary>Every file under assets/ must be listed in manifest.json, like every dossier-NNNN.jsonl; links are never followed.</summary>
    private static List<ImportSkip> RejectUnlistedAssets(string root, HashSet<string> listedAssets)
    {
        var skipped = new List<ImportSkip>();
        var assets = new DirectoryInfo(Path.Combine(root, "assets"));
        if (assets.Exists && !IsLink(assets))
        {
            Walk(assets);
        }

        return skipped;

        void Walk(DirectoryInfo directory)
        {
            foreach (var entry in directory.EnumerateFileSystemInfos("*", new EnumerationOptions { AttributesToSkip = 0 }))
            {
                // Hidden entries (dot-files on Unix, Hidden or System on Windows: .DS_Store, Thumbs.db) are OS litter, not bundle
                // content: skipped and reported, never read, never descended into. Links are still never followed.
                var relativeName = Path.GetRelativePath(root, entry.FullName).Replace('\\', '/');
                if ((entry.Attributes & (FileAttributes.Hidden | FileAttributes.System)) != 0 && !listedAssets.Contains(relativeName))
                {
                    skipped.Add(new ImportSkip(relativeName, "hidden_file_ignored: a hidden or system file under assets/ is not part of the bundle; not read"));
                    continue;
                }

                if (entry is DirectoryInfo child && !IsLink(child))
                {
                    Walk(child);
                    continue;
                }

                var relative = Path.GetRelativePath(root, entry.FullName).Replace('\\', '/');
                if (!listedAssets.Contains(relative))
                {
                    throw new DossierRequestException("import_unlisted_file", $"{relative} is in the bundle directory but not listed in manifest.json; refusing to import a partly listed bundle");
                }
            }
        }
    }

    /// <summary>
    /// Streams one data file, verifying bytes, lines and sha256 against <paramref name="stats"/>, and hands each
    /// line (without its '\n') to <paramref name="onLine"/> with its 1-based number and byte offset. A line longer
    /// than <paramref name="maxLine"/> bytes fails before it is buffered whole.
    /// </summary>
    private static void ReadJsonlFile(
        string root,
        string name,
        (long Bytes, long Lines, string Sha) stats,
        long maxLine,
        Action<long, long, ReadOnlyMemory<byte>> onLine)
    {
        var info = new FileInfo(Path.Combine(root, name));
        if (!info.Exists)
        {
            throw new DossierRequestException("import_file_missing", $"manifest.json lists {name} but the file is not in the bundle");
        }

        if (IsLink(info))
        {
            throw new DossierRequestException("import_unsafe_path", $"{name} is a symbolic link or reparse point; refusing to read it");
        }

        using var stream = OpenRegularFile(info.FullName, name, ImportChunkBytes);
        if (info.Length != stats.Bytes)
        {
            throw new DossierRequestException("import_file_mismatch", $"{name} is {info.Length} bytes but file_stats says {stats.Bytes}");
        }

        using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        var chunk = new byte[ImportChunkBytes];
        var buffer = new byte[4096];
        var length = 0;
        long chunkBase = 0;
        long lineNumber = 0;
        long lineStart = 0;
        int read;
        while ((read = stream.Read(chunk, 0, chunk.Length)) > 0)
        {
            if (chunkBase + read > stats.Bytes)
            {
                throw new DossierRequestException("import_file_mismatch", $"{name} holds more than the {stats.Bytes} bytes file_stats says; stopped reading");
            }

            hash.AppendData(chunk, 0, read);
            var position = 0;
            while (position < read)
            {
                var newline = Array.IndexOf(chunk, (byte)'\n', position, read - position);
                var segmentEnd = newline < 0 ? read : newline;
                var segmentLength = segmentEnd - position;
                if (length + (long)segmentLength > maxLine)
                {
                    throw new DossierRequestException(
                        "import_line_too_long",
                        $"{name}:{(lineNumber + 1).ToString(CultureInfo.InvariantCulture)} is longer than the {maxLine}-byte line limit; refusing to buffer it");
                }

                if (length + segmentLength > buffer.Length)
                {
                    Array.Resize(ref buffer, (int)Math.Min(maxLine, Math.Max((long)buffer.Length * 2, length + segmentLength)));
                }

                Buffer.BlockCopy(chunk, position, buffer, length, segmentLength);
                length += segmentLength;
                if (newline < 0)
                {
                    break;
                }

                lineNumber++;
                onLine(lineNumber, lineStart, new ReadOnlyMemory<byte>(buffer, 0, length));
                length = 0;
                position = newline + 1;
                lineStart = chunkBase + position;
            }

            chunkBase += read;
        }

        if (length > 0)
        {
            throw new DossierRequestException("import_file_mismatch", $"{name} does not end with a newline: its last line is not terminated");
        }

        if (chunkBase != stats.Bytes || lineNumber != stats.Lines)
        {
            throw new DossierRequestException("import_file_mismatch", $"{name} holds {chunkBase} bytes in {lineNumber} lines but file_stats says {stats.Bytes} bytes in {stats.Lines} lines");
        }

        var actual = Convert.ToHexString(hash.GetHashAndReset()).ToLowerInvariant();
        if (actual != stats.Sha)
        {
            throw new DossierRequestException("import_file_mismatch", $"{name} sha256 {actual} does not match file_stats ({stats.Sha})");
        }
    }

    private (bool Restored, string Reason) RestoreJsonlBlob(
        string root,
        string sha,
        Dictionary<string, JsonlAsset> assets,
        HashSet<string> listedAssets)
    {
        if (!Sha256Hex.IsMatch(sha))
        {
            return (false, "sha256 is not 64 lowercase hex characters");
        }

        if (!assets.TryGetValue(sha, out var asset))
        {
            return (false, "bytes absent from the bundle (exported without an asset record, e.g. --assets none); the store keeps the attachment row without its blob");
        }

        if (asset.Missing)
        {
            return (false, "the blob was missing when the bundle was published (missing asset record); the store keeps the attachment row without its blob");
        }

        var target = Path.Combine(BlobRoot, sha);
        if (asset.HasData)
        {
            return RestoreEmbeddedBlob(root, asset, target);
        }

        if (asset.Path is null)
        {
            return (false, "asset record carries neither embedded data nor a path");
        }

        return RestoreFileBlob(root, asset, target, listedAssets);
    }

    private (bool Restored, string Reason) RestoreFileBlob(string root, JsonlAsset asset, string target, HashSet<string> listedAssets)
    {
        var path = asset.Path!;
        var expectedStem = "assets/" + asset.Sha;
        var exact = JsonlAssetPathRegex.IsMatch(path)
            && path.StartsWith(expectedStem, StringComparison.Ordinal)
            && (path.Length == expectedStem.Length || path[expectedStem.Length] == '.');
        if (!exact)
        {
            return (false, $"asset path \"{path}\" is not assets/<this asset's sha256>[.ext]; not read");
        }

        if (!listedAssets.Contains(path))
        {
            return (false, $"asset path \"{path}\" is not listed in manifest.json files; not read");
        }

        var rootWithSeparator = Path.GetFullPath(root).TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
        var full = Path.GetFullPath(Path.Combine(root, path));
        if (!full.StartsWith(rootWithSeparator, StringComparison.Ordinal))
        {
            return (false, $"asset path \"{path}\" resolves outside the bundle; not read");
        }

        var directory = new DirectoryInfo(Path.GetDirectoryName(full)!);
        var file = new FileInfo(full);
        if (!file.Exists)
        {
            return (false, $"asset file {path} is not in the bundle; the store keeps the attachment row without its blob");
        }

        if (IsLink(directory) || IsLink(file))
        {
            return (false, $"asset file {path} is a symbolic link or reparse point; not read");
        }

        Directory.CreateDirectory(BlobRoot);
        var temporary = target + ".import-" + Guid.NewGuid().ToString("N");
        try
        {
            using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
            using (var input = OpenRegularFile(full, path, ImportChunkBytes))
            using (var output = new FileStream(temporary, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                // A handle that holds less than the record declares yields a short copy; the sha256 check below then skips it with a reason.
                var limit = AssetCopyLimit(asset.Bytes, input.Length);
                if (!CopyAtMost(input, output, hash, limit))
                {
                    return (false, $"{path} holds more than the {limit} bytes it should; not read further");
                }
            }

            if (Convert.ToHexString(hash.GetHashAndReset()).ToLowerInvariant() != asset.Sha)
            {
                return (false, $"{path} does not hash to the recorded sha256; blob not restored");
            }

            if (!File.Exists(target))
            {
                File.Move(temporary, target);
            }

            return (true, string.Empty);
        }
        catch (DossierRequestException exception) when (exception.Code == "import_not_regular_file")
        {
            return (false, $"asset file {path} is not a regular file; not read");
        }
        finally
        {
            if (File.Exists(temporary))
            {
                File.Delete(temporary);
            }
        }
    }

    private (bool Restored, string Reason) RestoreEmbeddedBlob(string root, JsonlAsset asset, string target)
    {
        // Pass 2 re-reads exactly the asset line pass 1 located; the data file was verified as a whole already.
        var line = new byte[asset.Length];
        try
        {
            using var stream = OpenRegularFile(Path.Combine(root, asset.File), asset.File, 4096);
            stream.Seek(asset.Offset, SeekOrigin.Begin);
            stream.ReadExactly(line, 0, line.Length);
        }
        catch (Exception exception) when (exception is IOException or DossierRequestException)
        {
            return (false, $"asset line {asset.File}:{asset.Line} could not be re-read: {exception.Message}");
        }

        string? encoding = null;
        long declared = -1;
        var dataStart = -1;
        var dataLength = 0;
        var escaped = false;
        var reader = new Utf8JsonReader(line);
        try
        {
            var depth = 0;
            while (reader.Read())
            {
                if (reader.TokenType is JsonTokenType.StartObject or JsonTokenType.StartArray)
                {
                    depth++;
                }
                else if (reader.TokenType is JsonTokenType.EndObject or JsonTokenType.EndArray)
                {
                    depth--;
                }
                else if (reader.TokenType == JsonTokenType.PropertyName && depth == 1)
                {
                    var property = reader.GetString();
                    reader.Read();
                    switch (property)
                    {
                        case "encoding" when reader.TokenType == JsonTokenType.String:
                            encoding = reader.GetString();
                            break;
                        case "bytes" when reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out var value):
                            declared = value;
                            break;
                        case "data" when reader.TokenType == JsonTokenType.String:
                            escaped = reader.ValueIsEscaped;
                            dataStart = (int)reader.TokenStartIndex + 1;
                            dataLength = reader.ValueSpan.Length;
                            break;
                        default:
                            if (reader.TokenType is JsonTokenType.StartObject or JsonTokenType.StartArray)
                            {
                                depth++;
                            }

                            break;
                    }
                }
            }
        }
        catch (JsonException exception)
        {
            return (false, $"asset line {asset.File}:{asset.Line} is not valid JSON: {exception.Message}");
        }

        if (encoding != "base64")
        {
            return (false, $"embedded asset encoding is \"{encoding}\"; only base64 is supported");
        }

        if (declared < 0 || declared > MaxEmbedAssetBytes)
        {
            return (false, $"declared asset size {declared} is outside the {MaxEmbedAssetBytes}-byte embed limit; not decoded");
        }

        if (dataStart < 0 || escaped)
        {
            return (false, "embedded data is missing or contains JSON escapes; not decoded");
        }

        var expected = 4 * ((declared + 2) / 3);
        if (dataLength != expected)
        {
            return (false, $"base64 data length {dataLength} does not match 4*ceil(bytes/3) = {expected} for {declared} bytes; not decoded");
        }

        var buffer = new byte[(dataLength / 4) * 3];
        if (Base64.DecodeFromUtf8(line.AsSpan(dataStart, dataLength), buffer, out _, out var written) != System.Buffers.OperationStatus.Done || written != declared)
        {
            return (false, "embedded data is not valid base64 of the declared size; not decoded");
        }

        var content = buffer.AsSpan(0, (int)declared);
        if (!Convert.ToHexString(SHA256.HashData(content)).Equals(asset.Sha, StringComparison.OrdinalIgnoreCase))
        {
            return (false, $"embedded data does not hash to the recorded sha256 ({asset.File}:{asset.Line}); blob not restored");
        }

        if (!File.Exists(target))
        {
            // Temp file then move, like RestoreFileBlob: a crash never leaves a truncated content-addressed blob.
            Directory.CreateDirectory(BlobRoot);
            var temporary = target + ".import-" + Guid.NewGuid().ToString("N");
            try
            {
                using (var output = new FileStream(temporary, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                {
                    output.Write(content);
                }

                if (!File.Exists(target))
                {
                    File.Move(temporary, target);
                }
            }
            finally
            {
                if (File.Exists(temporary))
                {
                    File.Delete(temporary);
                }
            }
        }

        return (true, string.Empty);
    }
}

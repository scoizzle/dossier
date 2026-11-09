using System.Text.Json;

namespace Dossier;

/// <summary>post_facts request, per contract/ops.schema.json.</summary>
public sealed class PostFactsRequest
{
    public string? IdempotencyKey { get; set; }
    public SubjectInput? Subject { get; set; }
    public List<string>? Redact { get; set; }
    public List<FactInput> Facts { get; set; } = new();
}

/// <summary>Subject by name (with optional kind/parent/aliases) or by id.</summary>
public sealed class SubjectInput
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Kind { get; set; }
    public string? Parent { get; set; }
    public List<string>? Aliases { get; set; }
}

public sealed class FactInput
{
    public string? Key { get; set; }
    public string? LocalId { get; set; }
    public string? Kind { get; set; }
    public string? Text { get; set; }
    public JsonElement? Data { get; set; }
    public List<ItemInput>? Items { get; set; }
    public List<string>? Tags { get; set; }
    public double? Confidence { get; set; }
    public List<RefInput>? Refs { get; set; }
    public List<AttachmentInput>? Attachments { get; set; }
}

public sealed class ItemInput
{
    public string? Key { get; set; }
    public string? Text { get; set; }
    public JsonElement? Locator { get; set; }
}

public sealed class RefInput
{
    public string? Rel { get; set; }
    public string? Kind { get; set; }
    public string? Target { get; set; }
    public JsonElement? Locator { get; set; }
    public string? Basis { get; set; }
    public double? Confidence { get; set; }
    public int? Seq { get; set; }
    public string? Rev { get; set; }
    public string? Snapshot { get; set; }
    public string? SnapshotHash { get; set; }
    public string? Etag { get; set; }
    public string? VerifiedAt { get; set; }
    public bool? Valid { get; set; }

    /// <summary>Shallow copy used when a local_id target is resolved.</summary>
    public RefInput Clone() => (RefInput)MemberwiseClone();
}

public sealed class AttachmentInput
{
    public string? Sha256 { get; set; }
    public string? Filename { get; set; }
    public string? Mime { get; set; }
    public long Bytes { get; set; }
    public JsonElement? Perceptual { get; set; }
}

public sealed class PostFactsResponse
{
    public SubjectResponse Subject { get; set; } = new();
    public List<FactResult> Facts { get; set; } = new();
}

public sealed class SubjectResponse
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool Created { get; set; }
    public string? Parent { get; set; }
}

public sealed class FactResult
{
    public string Id { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string? Replaced { get; set; }
    public string? DuplicateOf { get; set; }
}

/// <summary>An item the write path rejected; the rest of the batch still commits.</summary>
public sealed record PostError(int Index, string Code, string Message);

public sealed record PostResult(PostFactsResponse Response, IReadOnlyList<PostError> Errors);

public sealed record RetractResult(bool Found, string Id);

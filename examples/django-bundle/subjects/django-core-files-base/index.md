# django/core/files/base

- Subject: django/core/files/base (id `1fe53c64-0167-401d-a73f-d72e69b8b753`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1240 tokens
- Facts shown: 29 of 29
- Conflicts: 0
- Gaps: 0

## Highlights

- if not buffer_: # If this is the end of a \n or \r\n line, yield. if endswith_lf(line): yield line else: buffer_.append(line) elif endswith_lf(line): yield type(buffer_[0])().join(buffer_) buffer_ = [] [66d88145]
- NB: If a particular file representation is in memory, subclasses should always return ``False`` -- there's no good reason to read from memory in chunks. """ return self.size > (chunk_size or self.DEFAULT_CHUNK_SIZE) [08dffdee]
- if buffer_: yield type(buffer_[0])().join(buffer_) [1d09f6ed]
- while True: data = self.read(chunk_size) if not data: break yield data [394b5298]
- @cached_property def size(self): if hasattr(self.file, "size"): return self.file.size if hasattr(self.file, "name"): try: return os.path.getsize(self.file.name) except (OSError, TypeError): pass if hasattr(self.file, "tell") and hasattr(self.file, "seek"): pos = self.file.tell() self.file.seek(0, os.SEEK_END) size = self.file.tell() self.file.seek(pos) return size raise AttributeError("Unable to determine the file's size.") [c613a199]
- def __bool__(self): return True [4da7c256]
- def __enter__(self): return self [3ef33e95d940f83e]
- def __exit__(self, exc_type, exc_value, tb): self.close() [0612e692]
- def __init__(self, content, name=None): stream_class = StringIO if isinstance(content, str) else BytesIO super().__init__(stream_class(content), name=name) self.size = len(content) [a5fe05f5]
- def __init__(self, file, name=None): self.file = file if name is None: name = getattr(file, "name", None) self.name = name if hasattr(file, "mode"): self.mode = file.mode [93e0a2f5]
- def __iter__(self): # Iterate over this file-like object by newlines buffer_ = [] for chunk in self.chunks(): for line in chunk.splitlines(True): if buffer_: if endswith_cr(buffer_[-1]) and not equals_lf(line): # Line split after a \r newline; yield buffer_. yield type(buffer_[0])().join(buffer_) # Continue with line. buffer_ = [] else: # Line either split without a newline (line # continues after buffer_) or with \r\n # newline (line == b'\n'). buffer_.append(line) [ef9ab5ee]
- def __len__(self): return self.size [cb30ccf2]
- def __repr__(self): return "<%s: %s>" % (self.__class__.__name__, self.name or "None") [1e86d18b]
- def __str__(self): return "Raw content" [602b3f42]
- def __str__(self): return self.name or "" [93e0c227]
- def chunks(self, chunk_size=None): """ Read the file and yield chunks of ``chunk_size`` bytes (defaults to ``File.DEFAULT_CHUNK_SIZE``). """ chunk_size = chunk_size or self.DEFAULT_CHUNK_SIZE try: self.seek(0) except (AttributeError, UnsupportedOperation): pass [13b5426e]
- def close(self): pass [082632af]
- def close(self): self.file.close() [b7c5359a]
- def multiple_chunks(self, chunk_size=None): """ Return ``True`` if you can expect multiple chunks. [2bb330b1]
- def open(self, mode=None): self.seek(0) return self [9e5c0138]
- def write(self, data): self.__dict__.pop("size", None) # Clear the computed size. return self.file.write(data) [c67a8a3c]

## All facts

- [4e8c0f4c] def open(self, mode=None, *args, **kwargs): if not self.closed: self.seek(0) elif self.name and os.path.exists(self.name): self.file = open(self.name, mode or self.mode, *args, **kwargs) else: raise ValueError("The file cannot be reopened.") return self
- [f227321c] class ContentFile(File): """ A File-like object that takes just raw content, rather than an actual file. """
- [ab9349c4] class File(FileProxyMixin): DEFAULT_CHUNK_SIZE = 64 * 2**10
- [e3299203] def endswith_cr(line): """Return True if line (a text or bytestring) ends with '\r'.""" return line.endswith("\r" if isinstance(line, str) else b"\r")
- [7139138f] def endswith_lf(line): """Return True if line (a text or bytestring) ends with '\n'.""" return line.endswith("\n" if isinstance(line, str) else b"\n")
- [75a73392] def equals_lf(line): """Return True if line (a text or bytestring) equals '\n'.""" return line == ("\n" if isinstance(line, str) else b"\n")
- [ffde5616] from django.core.files.utils import FileProxyMixin from django.utils.functional import cached_property
- [f9a6b5df] import os from io import BytesIO, StringIO, UnsupportedOperation

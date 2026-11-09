# django/core/files/base

- Subject: django/core/files/base (id `631fc55b-d758-460d-adbd-d7ffab821d8c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 21 of 29
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

8 more facts did not fit in the budget: [4e8c0f4c] [f227321c] [ab9349c4] [e3299203] [7139138f] [75a73392] [ffde5616] [f9a6b5df]

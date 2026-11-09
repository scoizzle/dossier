# django/core/files/utils

- Subject: django/core/files/utils (id `c6c32bbf-9fe3-43f8-b513-3af2786448b6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 686 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- class FileProxy(FileProxyMixin): def __init__(self, file): self.file = file """ [6f2c1264]
- @property def closed(self): return not self.file or self.file.closed [0258d8bc]
- def __iter__(self): return iter(self.file) [a1086f90]
- def readable(self): if self.closed: return False if hasattr(self.file, "readable"): return self.file.readable() return True [387573f0]
- def seekable(self): if self.closed: return False if hasattr(self.file, "seekable"): return self.file.seekable() return True [b2b5706c]
- def writable(self): if self.closed: return False if hasattr(self.file, "writable"): return self.file.writable() return "w" in getattr(self.file, "mode", "") [9ef16825]
- encoding = property(lambda self: self.file.encoding) fileno = property(lambda self: self.file.fileno) flush = property(lambda self: self.file.flush) isatty = property(lambda self: self.file.isatty) newlines = property(lambda self: self.file.newlines) read = property(lambda self: self.file.read) readinto = property(lambda self: self.file.readinto) readline = property(lambda self: self.file.readline) readlines = property(lambda self: self.file.readlines) seek = property(lambda self: self.file.seek) tell = property(lambda self: self.file.tell) truncate = property(lambda self: self.file.truncate) write = property(lambda self: self.file.write) writelines = property(lambda self: self.file.writelines) [1bc8662c]
- if allow_relative_path: # Ensure that name can be treated as a pure posix path, i.e. Unix # style (with forward slashes). path = pathlib.PurePosixPath(str(name).replace("\\", "/")) if path.is_absolute() or ".." in path.parts: raise SuspiciousFileOperation( "Detected path traversal attempt in '%s'" % name ) elif name != os.path.basename(name): raise SuspiciousFileOperation("File name '%s' includes path elements" % name) [852a0a6a]
- return name [55927318]
- class FileProxyMixin: """ A mixin class used to forward file methods to an underlying file object. The internal file object has to be called "file":: [8ca84667]
- def validate_file_name(name, allow_relative_path=False): # Remove potentially dangerous names if os.path.basename(name) in {"", ".", ".."}: raise SuspiciousFileOperation("Could not derive file name from '%s'" % name) [78d08ee0]
- from django.core.exceptions import SuspiciousFileOperation [e73c82f699a7d4a5]
- import os import pathlib [43b6bfd121a04d01-2]

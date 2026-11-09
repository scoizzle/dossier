# django/core/files/temp

- Subject: django/core/files/temp (id `09cc5ff2-461f-406e-ae76-49510194856b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 708 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- # Because close can be called during shutdown # we need to cache os.unlink and access it # as self.unlink only unlink = os.unlink [9b464c42]
- Unlike tempfile.NamedTemporaryFile from the standard library, __init__() doesn't support the 'delete', 'buffering', 'encoding', or 'newline' keyword arguments. """ [6e21c8cd]
- def __del__(self): self.close() [bcaca52c]
- def __enter__(self): self.file.__enter__() return self [7df5ae09]
- def __exit__(self, exc, value, tb): self.file.__exit__(exc, value, tb) [8254b148]
- def __init__(self, mode="w+b", bufsize=-1, suffix="", prefix="", dir=None): fd, name = tempfile.mkstemp(suffix=suffix, prefix=prefix, dir=dir) self.name = name self.file = os.fdopen(fd, mode, bufsize) self.close_called = False [748c46e8]
- def close(self): if not self.close_called: self.close_called = True try: self.file.close() except OSError: pass try: self.unlink(self.name) except OSError: pass [1d2bd2fa]
- NamedTemporaryFile = TemporaryFile else: NamedTemporaryFile = tempfile.NamedTemporaryFile [5935bd15]
- class TemporaryFile(FileProxyMixin): """ Temporary file object constructor that supports reopening of the temporary file in Windows. [06a4d520]
- """ The temp module provides a NamedTemporaryFile that can be reopened in the same process on any platform. Most platforms use the standard Python tempfile.NamedTemporaryFile class, but Windows users are given a custom class. [682da50e]
- 1: https://mail.python.org/pipermail/python-list/2005-December/336955.html 2: https://bugs.python.org/issue14243 """ [29f7233c]
- The custom version of NamedTemporaryFile doesn't support the same keyword arguments available in tempfile.NamedTemporaryFile. [df90b870]
- This is needed because the Python implementation of NamedTemporaryFile uses the O_TEMPORARY flag under Windows, which prevents the file from being reopened if the same flag is not provided [1][2]. Note that this does not address the more general issue of opening a file for writing and reading in multiple processes in a manner that works across platforms. [d2696fd3]
- __all__ = ( "NamedTemporaryFile", "gettempdir", ) [40146d9f]
- from django.core.files.utils import FileProxyMixin [af25411c]
- gettempdir = tempfile.gettempdir [2891d735]
- if os.name == "nt": [a2a8bf6f]
- import os import tempfile [628d898a]

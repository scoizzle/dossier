# django/utils/_os

- Subject: django/utils/_os (id `16a3f5bd-0ca6-466c-aafe-aaafd94cc99a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 879 tokens
- Facts shown: 6 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- """ head, tail = os.path.split(name) if not tail: head, tail = os.path.split(head) if head and tail and not os.path.exists(head): try: if parent_mode is not None: makedirs( head, mode=parent_mode, exist_ok=exist_ok, parent_mode=parent_mode ) else: makedirs(head, exist_ok=exist_ok) except FileExistsError: # Defeats race condition when another thread created the path pass cdir = curdir if isinstance(tail, bytes): cdir = bytes(curdir, "ASCII") if tail == cdir: # xxx/newdir/. exists if xxx/newdir exists return try: os.mkdir(name, mode) # PY315: The call to `chmod()` is not in the CPython proposed code. # Apply `chmod()` after `mkdir()` to enforce the exact requested # permissions, since the kernel masks the mode argument with the # process umask. This guarantees consistent directory permissions # without mutating global umask state. os.chmod(name, mode) except OSError: # Cannot rely on checking for EEXIST, since the operating system # could give priority to other errors like EACCES or EROFS if not exist_ok or not os.path.isdir(name): raise [9441c1c6]
- Raise SuspiciousFileOperation if the final path isn't located inside of the base path component. """ final_path = abspath(join(base, *paths)) base_path = abspath(base) # Ensure final_path starts with base_path (using normcase to ensure we # don't false-negative on case insensitive operating systems like Windows), # further, one of the following conditions must be true: # a) The next character is the path separator (to prevent conditions like # safe_join("/dir", "/../d")) # b) The final path must be the same as the base path. # c) The base path must be the most root path (meaning either "/" or # "C:\\") if ( not normcase(final_path).startswith(normcase(base_path + sep)) and normcase(final_path) != normcase(base_path) and dirname(normcase(base_path)) != normcase(base_path) ): raise SuspiciousFileOperation( "The joined path ({}) is located outside of the base path " "component ({})".format(final_path, base_path) ) return final_path [334b7f9c]
- Super-mkdir; create a leaf directory and all intermediate ones. Works like mkdir, except that any intermediate path segment (not just the rightmost) will be created if it does not exist. If the target directory already exists, raise an OSError if exist_ok is False. Otherwise no exception is raised. If parent_mode is not None, it will be used as the mode for any newly-created, intermediate-level directories. Otherwise, intermediate directories are created with the default permissions (respecting umask). This is recursive. [479a8f9b]
- # Copied verbatim (minus `os.path` fixes) from: # https://github.com/python/cpython/pull/23901. # Python versions >= PY315 may include this fix, so periodic checks are needed # to remove this vendored copy of `makedirs` once solved upstream. def makedirs(name, mode=0o777, exist_ok=False, *, parent_mode=None): """makedirs(name [, mode=0o777][, exist_ok=False][, parent_mode=None]) [f26f73c1]
- def safe_join(base, *paths): """ Join one or more path components to the base path component intelligently. Return a normalized, absolute version of the final path. [88647cb3]
- def safe_makedirs(name, mode=0o777, exist_ok=False): """Create directories recursively with explicit `mode` on each level.""" makedirs(name=name, mode=mode, exist_ok=exist_ok, parent_mode=mode) [cbe4b8e7]

## Beyond the budget

4 more facts did not fit in the budget: [9aea2d9f] [c450246d] [e73c82f699a7d4a5-2] [9fc3545a]

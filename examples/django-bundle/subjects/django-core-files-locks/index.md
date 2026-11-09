# django/core/files/locks

- Subject: django/core/files/locks (id `543cf7c9-b9f7-4a7c-a7cf-ebd92f4971da`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1004 tokens
- Facts shown: 25 of 25
- Conflicts: 0
- Gaps: 0

## Highlights

- # Dummy functions that don't do anything. def lock(f, flags): # File is not locked return False [39541af0]
- LOCK_SH = fcntl.LOCK_SH # shared lock LOCK_NB = fcntl.LOCK_NB # non-blocking LOCK_EX = fcntl.LOCK_EX except (ImportError, AttributeError): # File locking is not supported. LOCK_EX = LOCK_SH = LOCK_NB = 0 [bc45a98d]
- def lock(f, flags): try: fcntl.flock(_fd(f), flags) return True except BlockingIOError: return False [beb333e1]
- def unlock(f): # File is unlocked return True [e805bf04]
- def unlock(f): fcntl.flock(_fd(f), fcntl.LOCK_UN) return True [5cdeb519]
- # --- Adapted from the pyserial project --- # detect size of ULONG_PTR if sizeof(c_ulong) != sizeof(c_void_p): ULONG_PTR = c_int64 else: ULONG_PTR = c_ulong PVOID = c_void_p [7837c109]
- # --- Define function prototypes for extra safety --- kernel32 = WinDLL("kernel32") LockFileEx = kernel32.LockFileEx LockFileEx.restype = BOOL LockFileEx.argtypes = [HANDLE, DWORD, DWORD, DWORD, DWORD, LPOVERLAPPED] UnlockFileEx = kernel32.UnlockFileEx UnlockFileEx.restype = BOOL UnlockFileEx.argtypes = [HANDLE, DWORD, DWORD, DWORD, LPOVERLAPPED] [83005eb3]
- # --- Union inside Structure by stackoverflow:3480240 --- class _OFFSET(Structure): _fields_ = [("Offset", DWORD), ("OffsetHigh", DWORD)] [0d1d8ab7]
- >>> from django.core.files import locks >>> with open('./file', 'wb') as f: ... locks.lock(f, locks.LOCK_EX) ... f.write('Django') """ [ad585347]
- LOCK_SH = 0 # the default LOCK_NB = 0x1 # LOCKFILE_FAIL_IMMEDIATELY LOCK_EX = 0x2 # LOCKFILE_EXCLUSIVE_LOCK [f3314160]
- LPOVERLAPPED = POINTER(OVERLAPPED) [daa917dd]
- class OVERLAPPED(Structure): _anonymous_ = ["_offset_union"] _fields_ = [ ("Internal", ULONG_PTR), ("InternalHigh", ULONG_PTR), ("_offset_union", _OFFSET_UNION), ("hEvent", HANDLE), ] [d74216a8]
- class _OFFSET_UNION(Union): _anonymous_ = ["_offset"] _fields_ = [("_offset", _OFFSET), ("Pointer", PVOID)] [69bc8b6a]
- def lock(f, flags): hfile = msvcrt.get_osfhandle(_fd(f)) overlapped = OVERLAPPED() ret = LockFileEx(hfile, flags, 0, 0, 0xFFFF0000, byref(overlapped)) return bool(ret) [8e879a06]
- def unlock(f): hfile = msvcrt.get_osfhandle(_fd(f)) overlapped = OVERLAPPED() ret = UnlockFileEx(hfile, 0, 0, 0xFFFF0000, byref(overlapped)) return bool(ret) [387f117e]
- else: [6ad07797f4838346-3]
- """ Portable file locking utilities. [3b40b2a0]
- Based partially on an example by Jonathan Feignberg in the Python Cookbook [1] (licensed under the Python Software License) and a ctypes port by Anatoly Techtonik for Roundup [2] (license [3]). [401469e6]
- Example Usage:: [68fcec9c]
- [1] https://code.activestate.com/recipes/65203/ [2] https://sourceforge.net/p/roundup/code/ci/default/tree/roundup/backends/portalocker.py # NOQA [3] https://sourceforge.net/p/roundup/code/ci/default/tree/COPYING.txt [8898fce1]
- __all__ = ("LOCK_EX", "LOCK_SH", "LOCK_NB", "lock", "unlock") [5b4e2449]
- else: try: import fcntl [3ecc835e]

## All facts

- [7d5a6878] def _fd(f): """Get a filedescriptor from something which could be a file or an fd.""" return f.fileno() if hasattr(f, "fileno") else f
- [3d786ab6] if os.name == "nt": import msvcrt from ctypes import ( POINTER, Structure, Union, WinDLL, byref, c_int64, c_ulong, c_void_p, sizeof, ) from ctypes.wintypes import BOOL, DWORD, HANDLE
- [bbf3e0cdec1c52e4-4] import os

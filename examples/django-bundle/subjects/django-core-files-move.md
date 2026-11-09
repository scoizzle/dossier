# django/core/files/move

- Subject: django/core/files/move (id `fe4a2ed5-1bff-4b93-b79a-08416b57d892`)
- Kind: subject
- Budget: 1200 tokens
- Used: 731 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- # first open the old file, so that it won't go away with open(old_file_name, "rb") as old_file: # now open the new file, not forgetting allow_overwrite fd = os.open( new_file_name, ( os.O_WRONLY | os.O_CREAT | getattr(os, "O_BINARY", 0) | (os.O_EXCL if not allow_overwrite else 0) | os.O_TRUNC ), ) try: locks.lock(fd, locks.LOCK_EX) current_chunk = None while current_chunk != b"": current_chunk = old_file.read(chunk_size) os.write(fd, current_chunk) finally: locks.unlock(fd) os.close(fd) [3509f37a]
- >>> from django.core.files.move import file_move_safe >>> file_move_safe("/tmp/old_file", "/tmp/new_file") """ [b1c44a3e]
- First, try ``os.rename``, which is simple but will break across filesystems. If that fails, stream manually from one file to another in pure Python. [7501c9ea]
- If the destination file exists and ``allow_overwrite`` is ``False``, raise ``FileExistsError``. """ # There's no reason to move if we don't have to. try: if os.path.samefile(old_file_name, new_file_name): return except OSError: pass [cd6e7623]
- if not allow_overwrite and os.access(new_file_name, os.F_OK): raise FileExistsError( f"Destination file {new_file_name} exists and allow_overwrite is False." ) [3fc52525]
- try: copystat(old_file_name, new_file_name) except PermissionError: # Certain filesystems (e.g. CIFS) fail to copy the file's metadata if # the type of the destination filesystem isn't the same as the source # filesystem. This also happens with some SELinux-enabled systems. # Ignore that, but try to set basic permissions. try: copymode(old_file_name, new_file_name) except PermissionError: pass [d977dc10]
- try: os.remove(old_file_name) except PermissionError as e: # Certain operating systems (Cygwin and Windows) # fail when deleting opened files, ignore it. (For the # systems where this happens, temporary files will be auto-deleted # on close anyway.) if getattr(e, "winerror", 0) != 32: raise [4c50ddd7]
- try: os.rename(old_file_name, new_file_name) return except OSError: # OSError happens with os.rename() if moving to another filesystem or # when moving opened files on certain operating systems. pass [92316279]
- """ Move a file in the safest way possible:: [31a97e4e]
- __all__ = ["file_move_safe"] [cdb5d5f4]
- def file_move_safe( old_file_name, new_file_name, chunk_size=1024 * 64, allow_overwrite=False ): """ Move a file from one location to another in the safest way possible. [903e067d]
- from django.core.files import locks [4ef54b1d]
- import os from shutil import copymode, copystat [4b7c6028]

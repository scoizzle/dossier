# django/core/files/storage/filesystem

- Subject: django/core/files/storage/filesystem (id `60dab3e3-6ebb-48ad-86e9-aa1d055f3a25`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 11 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- # This is a normal uploadedfile that we can stream. else: # The combination of O_CREAT and O_EXCL makes os.open() # raises an OSError if the file already exists before it's # opened. open_flags = ( os.O_WRONLY | os.O_CREAT | os.O_EXCL | getattr(os, "O_BINARY", 0) ) if self._allow_overwrite: open_flags = open_flags & ~os.O_EXCL | os.O_TRUNC fd = os.open(full_path, open_flags, 0o666) _file = None try: locks.lock(fd, locks.LOCK_EX) for chunk in content.chunks(): if _file is None: mode = "wb" if isinstance(chunk, bytes) else "wt" _file = os.fdopen(fd, mode) _file.write(chunk) finally: locks.unlock(fd) if _file is not None: _file.close() else: os.close(fd) except FileExistsError: # A new name is needed if the file exists. name = self.get_available_name(name) full_path = self.path(name) else: # OK, the file save worked. Break out of the loop. break [dbef7366]
- # Create any intermediate directories that do not exist. directory = os.path.dirname(full_path) try: if self.directory_permissions_mode is not None: # Workaround because os.makedirs() doesn't apply the "mode" # argument to intermediate-level directories. # https://github.com/python/cpython/issues/86533 safe_makedirs(directory, self.directory_permissions_mode, exist_ok=True) else: os.makedirs(directory, exist_ok=True) except FileExistsError: raise FileExistsError("%s exists and is not a directory." % directory) [58d17665]
- # Ensure the saved path is always relative to the storage root. name = os.path.relpath(full_path, self.location) # Ensure the moved file has the same gid as the storage root. self._ensure_location_group_id(full_path) # Store filenames with forward slashes, even on Windows. return str(name).replace("\\", "/") [d097110c]
- # There's a potential race condition between get_available_name and # saving the file; it's possible that two threads might return the # same name, at which point all sorts of fun happens. So we need to # try to create the file, but if it already exists we have to go back # to get_available_name() and try again. [65c32e24]
- if self.file_permissions_mode is not None: os.chmod(full_path, self.file_permissions_mode) [c693ee83]
- while True: try: # This file has a file path that we can move. if hasattr(content, "temporary_file_path"): file_move_safe( content.temporary_file_path(), full_path, allow_overwrite=self._allow_overwrite, ) [11523f5b]
- @cached_property def base_location(self): return self._value_or_setting(self._location, settings.MEDIA_ROOT) [7a31e0fac4ec8b62]
- @cached_property def base_url(self): if self._base_url is not None and not self._base_url.endswith("/"): self._base_url += "/" return self._value_or_setting(self._base_url, settings.MEDIA_URL) [b2e1396457fbae67]
- @cached_property def directory_permissions_mode(self): return self._value_or_setting( self._directory_permissions_mode, settings.FILE_UPLOAD_DIRECTORY_PERMISSIONS ) [f8d33481c24a6fb0]
- @cached_property def location(self): return os.path.abspath(self.base_location) [09859160e487624d]
- def _datetime_from_timestamp(self, ts): """ If timezone support is enabled, make an aware datetime object in UTC; otherwise make a naive one in the local timezone. """ tz = UTC if settings.USE_TZ else None return datetime.fromtimestamp(ts, tz=tz) [7c83ae20]

## Beyond the budget

19 more facts did not fit in the budget: [2e4e54cc] [9a83e9b4] [eb5a06b0] [03b72c37] [5628fb89] [09e8e104] [378031bb] [96dfd197] [b95d307d] [0c265f19] [5e945a37] [678694e9] [2fcfcf800996fb0e] [9e2d005b] [252d6834eaf0da2d] [86edc436] [423d3b0acaf4528f] [c116cfc5] [569bfca8]

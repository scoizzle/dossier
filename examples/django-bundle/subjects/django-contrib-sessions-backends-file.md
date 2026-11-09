# django/contrib/sessions/backends/file

- Subject: django/contrib/sessions/backends/file (id `7042c4b3-7b4c-4d26-8ef8-6857248739a9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 885 tokens
- Facts shown: 13 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- # Remove expired sessions. expiry_age = self.get_expiry_age(expiry=self._expiry_date(session_data)) if expiry_age <= 0: session_data = {} self.delete() self.create() except (OSError, SuspiciousOperation): self._session_key = None return session_data [52908ae0]
- # This will atomically rename the file (os.rename) if the OS # supports it. Otherwise this will result in a shutil.copy2 # and os.unlink (for example on Windows). See #9084. shutil.move(output_file_name, session_file_name) renamed = True finally: if not renamed: os.unlink(output_file_name) except (EOFError, OSError): pass [59404c36]
- cls._storage_path = storage_path return storage_path [17c34c3d]
- # Make sure we're not vulnerable to directory traversal. Session keys # should always be md5s, so they should never contain directory # components. if not set(session_key).issubset(VALID_KEY_CHARS): raise InvalidSessionKey("Invalid characters in session key") [509b384f]
- # Write the session file without interfering with other threads # or processes. By writing to an atomically generated temporary # file and then using the atomic os.rename() to make the complete # file visible, we avoid having to lock the session file, while # still maintaining its integrity. # # Note: Locking the session file was explored, but rejected in part # because in order to be atomic and cross-platform, it required a # long-lived lock file for each session, doubling the number of # files in the session storage directory at any given time. This # rename solution is cleaner and avoids any additional overhead # when reading the session data, which is the more common case # unless SESSION_SAVE_EVERY_REQUEST = True. # # See ticket #8616. dir, prefix = os.path.split(session_file_name) [8f1aab32]
- for session_file in os.listdir(storage_path): if not session_file.startswith(file_prefix): continue session_key = session_file.removeprefix(file_prefix) session = cls(session_key) # When an expired session is loaded, its file is removed, and a # new file is immediately created. Prevent this by disabling # the create() method. session.create = lambda: None session.load() [b7daa1c5]
- return os.path.join(self.storage_path, self.file_prefix + session_key) [32757479]
- session_file_name = self._key_to_file() [b3f62e6a]
- try: # Make sure the file exists. If it does not already exist, an # empty placeholder file is created. flags = os.O_WRONLY | getattr(os, "O_BINARY", 0) if must_create: flags |= os.O_EXCL | os.O_CREAT fd = os.open(session_file_name, flags) os.close(fd) except FileNotFoundError: if not must_create: raise UpdateError except FileExistsError: if must_create: raise CreateError [e48ee9ad]
- try: output_file_fd, output_file_name = tempfile.mkstemp( dir=dir, prefix=prefix + "_out_" ) renamed = False try: try: os.write(output_file_fd, self.encode(session_data).encode()) finally: os.close(output_file_fd) [6f56f3d4]
- @classmethod async def aclear_expired(cls): cls.clear_expired() [6e97fd1f]
- @classmethod def clear_expired(cls): storage_path = cls._get_storage_path() file_prefix = settings.SESSION_COOKIE_NAME [34e0f39a]
- async def acreate(self): return self.create() [68a23a21133f16c8]

## Beyond the budget

17 more facts did not fit in the budget: [c2a6960b] [e28fd16f0bd1d223] [c94ac93f] [2e418da7bff17f93] [b2f9a5437ca006dd] [3d5083aa] [0da14104] [cd194fe6] [74010e65] [305a22b6] [b0c21d4d] [4d9f847b] [73c15960] [ee37f922] [decac6b0] [abe37d6a] [eb6249e3]

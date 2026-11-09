# django/contrib/sessions/backends/file

- Subject: django/contrib/sessions/backends/file (id `9b449141-f9c1-4f93-ab14-ad015aeb5385`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1865 tokens
- Facts shown: 30 of 30
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [c2a6960b] @classmethod def _get_storage_path(cls): try: return cls._storage_path except AttributeError: storage_path = ( getattr(settings, "SESSION_FILE_PATH", None) or tempfile.gettempdir() ) # Make sure the storage path is valid. if not os.path.isdir(storage_path): raise ImproperlyConfigured( "The session storage path %r doesn't exist. Please set your" " SESSION_FILE_PATH setting to an existing directory in which" " Django can store session data." % storage_path )
- [e28fd16f0bd1d223] async def adelete(self, session_key=None): return self.delete(session_key=session_key)
- [c94ac93f] async def aexists(self, session_key): return self.exists(session_key)
- [2e418da7bff17f93] async def aload(self): return self.load()
- [b2f9a5437ca006dd] async def asave(self, must_create=False): return self.save(must_create=must_create)
- [3d5083aa] def __init__(self, session_key=None): self.storage_path = self._get_storage_path() self.file_prefix = settings.SESSION_COOKIE_NAME super().__init__(session_key)
- [0da14104] def _expiry_date(self, session_data): """ Return the expiry time of the file storing the session's content. """ return session_data.get("_session_expiry") or ( self._last_modification() + datetime.timedelta(seconds=self.get_session_cookie_age()) )
- [cd194fe6] def _key_to_file(self, session_key=None): """ Get the file associated with this session key. """ if session_key is None: session_key = self._get_or_create_session_key()
- [74010e65] def _last_modification(self): """ Return the modification time of the file storing the session's content. """ modification = os.stat(self._key_to_file()).st_mtime tz = datetime.UTC if settings.USE_TZ else None return datetime.datetime.fromtimestamp(modification, tz=tz)
- [305a22b6] def create(self): while True: self._session_key = self._get_new_session_key() try: self.save(must_create=True) except CreateError: continue self.modified = True return
- [b0c21d4d] def delete(self, session_key=None): if session_key is None: if self.session_key is None: return session_key = self.session_key try: os.unlink(self._key_to_file(session_key)) except OSError: pass
- [4d9f847b] def exists(self, session_key): return os.path.exists(self._key_to_file(session_key))
- [73c15960] def load(self): session_data = {} try: with open(self._key_to_file(), encoding="ascii") as session_file: file_data = session_file.read() # Don't fail if there is no data in the session file. # We may have opened the empty placeholder file. if file_data: try: session_data = self.decode(file_data) except (EOFError, SuspiciousOperation) as e: if isinstance(e, SuspiciousOperation): logger = logging.getLogger( "django.security.%s" % e.__class__.__name__ ) logger.warning(str(e)) self.create()
- [ee37f922] def save(self, must_create=False): if self.session_key is None: return self.create() # Get the session data now, before we start messing # with the file it is stored within. session_data = self._get_session(no_load=must_create)
- [decac6b0] class SessionStore(SessionBase): """ Implement a file based session store. """
- [abe37d6a] from django.conf import settings from django.contrib.sessions.backends.base import ( VALID_KEY_CHARS, CreateError, SessionBase, UpdateError, ) from django.contrib.sessions.exceptions import InvalidSessionKey from django.core.exceptions import ImproperlyConfigured, SuspiciousOperation
- [eb6249e3] import datetime import logging import os import shutil import tempfile

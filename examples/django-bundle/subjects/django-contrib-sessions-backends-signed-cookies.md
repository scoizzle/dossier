# django/contrib/sessions/backends/signed_cookies

- Subject: django/contrib/sessions/backends/signed_cookies (id `0dd4fd8b-ed05-472c-9ad6-bb40c6a3eb88`)
- Kind: subject
- Budget: 1200 tokens
- Used: 799 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod async def aclear_expired(cls): pass [d7a661a8dd775120-2]
- @classmethod def clear_expired(cls): pass [e3bc65c33728b0b9-2]
- async def acreate(self): return self.create() [68a23a21133f16c8-2]
- async def acycle_key(self): return self.cycle_key() [a6b0db28]
- async def adelete(self, session_key=None): return self.delete(session_key=session_key) [e28fd16f0bd1d223-2]
- async def aexists(self, session_key=None): return self.exists(session_key=session_key) [145cfc69]
- async def aload(self): return self.load() [2e418da7bff17f93-2]
- async def asave(self, must_create=False): return self.save(must_create=must_create) [b2f9a5437ca006dd-2]
- def _get_session_key(self): """ Instead of generating a random string, generate a secure url-safe base64-encoded string of data as our session key. """ return signing.dumps( self._session, compress=True, salt="django.contrib.sessions.backends.signed_cookies", serializer=self.serializer, ) [62088620]
- def create(self): """ To create a new key, set the modified flag so that the cookie is set on the client for the current request. """ self.modified = True [072f7b81]
- def cycle_key(self): """ Keep the same data but with a new key. Call save() and it will automatically save a cookie with a new key at the end of the request. """ self.save() [92408515]
- def delete(self, session_key=None): """ To delete, clear the session key and the underlying data structure and set the modified flag so that the cookie is set on the client for the current request. """ self._session_key = "" self._session_cache = {} self.modified = True [5afe7457]
- def exists(self, session_key=None): """ This method makes sense when you're talking to a shared resource, but it doesn't matter when you're storing the information in the client's cookie. """ return False [fee9a2f2]
- def save(self, must_create=False): """ To save, get the session key as a securely signed string and then set the modified flag so that the cookie is set on the client for the current request. """ self._session_key = self._get_session_key() self.modified = True [6a59d0a6]
- class SessionStore(SessionBase): def load(self): """ Load the data from the key itself instead of fetching from some external data store. Opposite of _get_session_key(), raise BadSignature if signature fails. """ try: return signing.loads( self.session_key, serializer=self.serializer, # This doesn't handle non-default expiry dates, see #19201 max_age=self.get_session_cookie_age(), salt="django.contrib.sessions.backends.signed_cookies", ) except Exception: # BadSignature, ValueError, or unpickling exceptions. If any of # these happen, reset the session. self.create() return {} [36892f47]
- from django.contrib.sessions.backends.base import SessionBase from django.core import signing [41b17e47]

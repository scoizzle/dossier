# django/contrib/sessions/backends/cache

- Subject: django/contrib/sessions/backends/cache (id `9aab8b64-6845-4740-a157-df7b72069591`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 15 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod async def aclear_expired(cls): pass [d7a661a8dd775120]
- @classmethod def clear_expired(cls): pass [e3bc65c33728b0b9]
- @property def cache_key(self): return self.cache_key_prefix + self._get_or_create_session_key() [d81664750c24bd6c]
- async def acache_key(self): return self.cache_key_prefix + await self._aget_or_create_session_key() [d3c572e8b8489e53]
- async def acreate(self): for i in range(10000): self._session_key = await self._aget_new_session_key() try: await self.asave(must_create=True) except CreateError: continue self.modified = True return raise RuntimeError( "Unable to create a new session key. " "It is likely that the cache is unavailable." ) [a5f90b77]
- async def adelete(self, session_key=None): if session_key is None: if self.session_key is None: return session_key = self.session_key await self._cache.adelete(self.cache_key_prefix + session_key) [39bcb87e]
- async def aexists(self, session_key): return bool(session_key) and await self._cache.ahas_key( self.cache_key_prefix + session_key ) [1f8673ea]
- async def aload(self): try: session_data = await self._cache.aget(await self.acache_key()) except Exception: session_data = None if session_data is not None: return session_data self._session_key = None return {} [4ba3eec1]
- async def asave(self, must_create=False): if self.session_key is None: return await self.acreate() if must_create: func = self._cache.aadd elif await self._cache.aget(await self.acache_key()) is not None: func = self._cache.aset else: raise UpdateError result = await func( await self.acache_key(), await self._aget_session(no_load=must_create), await self.aget_expiry_age(), ) if must_create and not result: raise CreateError [a3188a8e]
- cache_key_prefix = KEY_PREFIX [21dd5d42c599db0b]
- def __init__(self, session_key=None): self._cache = caches[settings.SESSION_CACHE_ALIAS] super().__init__(session_key) [efe5addada00b6dc]
- def create(self): # Because a cache can fail silently (e.g. memcache), we don't know if # we are failing to create a new session because of a key collision or # because the cache is missing. So we try for a (large) number of times # and then raise an exception. That's the risk you shoulder if using # cache backing. for i in range(10000): self._session_key = self._get_new_session_key() try: self.save(must_create=True) except CreateError: continue self.modified = True return raise RuntimeError( "Unable to create a new session key. " "It is likely that the cache is unavailable." ) [cb4f3c1a]
- def delete(self, session_key=None): if session_key is None: if self.session_key is None: return session_key = self.session_key self._cache.delete(self.cache_key_prefix + session_key) [0e56d147]
- def exists(self, session_key): return ( bool(session_key) and (self.cache_key_prefix + session_key) in self._cache ) [adb4186c]
- def load(self): try: session_data = self._cache.get(self.cache_key) except Exception: # Some backends (e.g. memcache) raise an exception on invalid # cache keys. If this happens, reset the session. See #17810. session_data = None if session_data is not None: return session_data self._session_key = None return {} [751f3833]

## Beyond the budget

4 more facts did not fit in the budget: [d77c3df5] [22ee6565] [0f4103ee] [0f7e983f]

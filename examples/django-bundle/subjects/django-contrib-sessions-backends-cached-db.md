# django/contrib/sessions/backends/cached_db

- Subject: django/contrib/sessions/backends/cached_db (id `4f439964-e209-4b65-b913-83e370d26ff4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 18 of 22
- Conflicts: 0
- Gaps: 0

## Facts

- if data is None: s = await self._aget_session_from_db() if s: data = self.decode(s.session_data) await self._cache.aset( await self.acache_key(), data, await self.aget_expiry_age(expiry=s.expire_date), ) else: data = {} return data [49340990]
- if data is None: s = self._get_session_from_db() if s: data = self.decode(s.session_data) self._cache.set( self.cache_key, data, self.get_expiry_age(expiry=s.expire_date) ) else: data = {} return data [299bcd91]
- @property def cache_key(self): return self.cache_key_prefix + self._get_or_create_session_key() [d81664750c24bd6c-2]
- async def acache_key(self): return self.cache_key_prefix + await self._aget_or_create_session_key() [d3c572e8b8489e53-2]
- async def adelete(self, session_key=None): await super().adelete(session_key) if session_key is None: if self.session_key is None: return session_key = self.session_key await self._cache.adelete(self.cache_key_prefix + session_key) [fdf20994]
- async def aexists(self, session_key): return ( session_key and (self.cache_key_prefix + session_key) in self._cache or await super().aexists(session_key) ) [d2014bab]
- async def aflush(self): """See flush().""" self.clear() await self.adelete(self.session_key) self._session_key = None [54a2bd0e]
- async def aload(self): try: data = await self._cache.aget(await self.acache_key()) except Exception: # Some backends (e.g. memcache) raise an exception on invalid # cache keys. If this happens, reset the session. See #17810. data = None [195e1fd1]
- async def asave(self, must_create=False): await super().asave(must_create) try: await self._cache.aset( await self.acache_key(), self._session, await self.aget_expiry_age(), ) except Exception: logger.exception("Error saving to cache (%s)", self._cache) [f7cfac89]
- cache_key_prefix = KEY_PREFIX [21dd5d42c599db0b-2]
- def __init__(self, session_key=None): self._cache = caches[settings.SESSION_CACHE_ALIAS] super().__init__(session_key) [efe5addada00b6dc-2]
- def delete(self, session_key=None): super().delete(session_key) if session_key is None: if self.session_key is None: return session_key = self.session_key self._cache.delete(self.cache_key_prefix + session_key) [6bb93af0]
- def exists(self, session_key): return ( session_key and (self.cache_key_prefix + session_key) in self._cache or super().exists(session_key) ) [9acd02c1]
- def flush(self): """ Remove the current session data from the database and regenerate the key. """ self.clear() self.delete(self.session_key) self._session_key = None [f1ef51e2]
- def load(self): try: data = self._cache.get(self.cache_key) except Exception: # Some backends (e.g. memcache) raise an exception on invalid # cache keys. If this happens, reset the session. See #17810. data = None [034d32ac]
- def save(self, must_create=False): super().save(must_create) try: self._cache.set(self.cache_key, self._session, self.get_expiry_age()) except Exception: logger.exception("Error saving to cache (%s)", self._cache) [e58289d4]
- """ Cached, database-backed sessions. """ [c86d0356]
- KEY_PREFIX = "django.contrib.sessions.cached_db" [aac7a56a]

## Beyond the budget

4 more facts did not fit in the budget: [00749459] [4c4ba151] [47bc951ed6a0e3cc-3] [686ab19f]

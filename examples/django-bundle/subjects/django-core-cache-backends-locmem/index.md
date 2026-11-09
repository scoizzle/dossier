# django/core/cache/backends/locmem

- Subject: django/core/cache/backends/locmem (id `7e669686-19fa-46b2-9a62-049a24dd1566`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 983 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Highlights

- def __init__(self, name, params): super().__init__(params) self._cache = _caches.setdefault(name, OrderedDict()) self._expire_info = _expire_info.setdefault(name, {}) self._lock = _locks.setdefault(name, Lock()) [183a578b]
- def _cull(self): if self._cull_frequency == 0: self._cache.clear() self._expire_info.clear() else: count = len(self._cache) // self._cull_frequency for i in range(count): key, _ = self._cache.popitem() del self._expire_info[key] [f4d2d215]
- def _delete(self, key): try: del self._cache[key] del self._expire_info[key] except KeyError: return False return True [10f7f38d]
- def _has_expired(self, key): exp = self._expire_info.get(key, -1) return exp is not None and exp <= time.time() [2122e325]
- def _set(self, key, value, timeout=DEFAULT_TIMEOUT): if len(self._cache) >= self._max_entries: self._cull() self._cache[key] = value self._cache.move_to_end(key, last=False) self._expire_info[key] = self.get_backend_timeout(timeout) [3f2b4d67]
- def add(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) pickled = pickle.dumps(value, self.pickle_protocol) with self._lock: if self._has_expired(key): self._set(key, pickled, timeout) return True return False [9c65eadf]
- def clear(self): with self._lock: self._cache.clear() self._expire_info.clear() [efa1cb0d]
- def delete(self, key, version=None): key = self.make_and_validate_key(key, version=version) with self._lock: return self._delete(key) [e2e7c4b7]
- def get(self, key, default=None, version=None): key = self.make_and_validate_key(key, version=version) with self._lock: if self._has_expired(key): self._delete(key) return default pickled = self._cache[key] self._cache.move_to_end(key, last=False) return pickle.loads(pickled) [a0d8b0f1]
- def has_key(self, key, version=None): key = self.make_and_validate_key(key, version=version) with self._lock: if self._has_expired(key): self._delete(key) return False return True [99665154]
- def incr(self, key, delta=1, version=None): key = self.make_and_validate_key(key, version=version) with self._lock: if self._has_expired(key): self._delete(key) raise ValueError("Key '%s' not found" % key) pickled = self._cache[key] value = pickle.loads(pickled) new_value = value + delta pickled = pickle.dumps(new_value, self.pickle_protocol) self._cache[key] = pickled self._cache.move_to_end(key, last=False) return new_value [d4af4f20]
- def set(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) pickled = pickle.dumps(value, self.pickle_protocol) with self._lock: self._set(key, pickled, timeout) [c233fd00]
- def touch(self, key, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) with self._lock: if self._has_expired(key): return False self._expire_info[key] = self.get_backend_timeout(timeout) return True [fd9e29e5]
- "Thread-safe in-memory cache backend." [e4a8560c]
- # Global in-memory store of cache data. Keyed by name, to provide # multiple named local memory caches. _caches = {} _expire_info = {} _locks = {} [1653510a]

## All facts

- [5471d938] class LocMemCache(BaseCache): pickle_protocol = pickle.HIGHEST_PROTOCOL
- [202de63835ade9f6-2] from django.core.cache.backends.base import DEFAULT_TIMEOUT, BaseCache
- [95325076] import pickle import time from collections import OrderedDict from threading import Lock

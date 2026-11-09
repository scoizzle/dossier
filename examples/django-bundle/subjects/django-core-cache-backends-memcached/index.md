# django/core/cache/backends/memcached

- Subject: django/core/cache/backends/memcached (id `d92525e2-efcc-4cf8-8478-f3876133b7a4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1726 tokens
- Facts shown: 32 of 32
- Conflicts: 0
- Gaps: 0

## Highlights

- # Exception type raised by the underlying client library for a # nonexistent key. self.LibraryValueNotFoundException = value_not_found_exception [ab366fe5]
- if timeout > 2592000: # 60*60*24*30, 30 days # See: # https://github.com/memcached/memcached/wiki/Programming#expiration # "Expiration times can be set from 0, meaning "never expire", to # 30 days. Any time higher than 30 days is interpreted as a Unix # timestamp date. If you want to expire an object on January 1st of # next year, this is how you do that." # # This means that we have to switch to absolute timestamps. timeout += int(time.time()) return int(timeout) [03a9d7a7]
- if timeout is None: # Using 0 in memcache sets a non-expiring timeout. return 0 elif int(timeout) == 0: # Other cache backends treat 0 as set-and-expire. To achieve this # in memcache backends, a negative timeout must be passed. timeout = -1 [ebf3bdb5]
- self._lib = library self._class = library.Client self._options = params.get("OPTIONS") or {} [9ffdf58a]
- super().__init__( server, params, library=pylibmc, value_not_found_exception=pylibmc.NotFound ) [f8f15122]
- super().__init__( server, params, library=pymemcache, value_not_found_exception=KeyError ) self._class = self._lib.HashClient self._options = { "allow_unicode_keys": True, "default_noreply": False, "serde": pymemcache.serde.pickle_serde, **self._options, } [c985f171]
- @cached_property def _cache(self): """ Implement transparent thread-safe access to a memcached client. """ return self._class(self.client_servers, **self._options) [05df996c]
- @property def client_servers(self): output = [] for server in self._servers: output.append(server.removeprefix("unix:")) return output [722c79ea]
- @property def client_servers(self): return self._servers [db628f9b]
- def __init__(self, server, params): import pylibmc [4fbacd03]
- def __init__(self, server, params): import pymemcache.serde [5c92d732]
- def add(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.add(key, value, self.get_backend_timeout(timeout)) [18c0ef7c0b3932df]
- def clear(self): self._cache.flush_all() [1f924e82]
- def close(self, **kwargs): # Many clients don't clean up connections properly. self._cache.disconnect_all() [ade1a3be]
- def close(self, **kwargs): # libmemcached manages its own connections. Don't call disconnect_all() # as it resets the failover state and creates unnecessary reconnects. pass [92247676]
- def delete(self, key, version=None): key = self.make_and_validate_key(key, version=version) return bool(self._cache.delete(key)) [96840ecc]
- def delete_many(self, keys, version=None): keys = [self.make_and_validate_key(key, version=version) for key in keys] self._cache.delete_multi(keys) [7c1a7467]
- def get(self, key, default=None, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.get(key, default) [1b1c3e7ac0a1ff09]
- "Memcached cache backend" [49aebb6e]

## All facts

- [2c46c9f6] def get_backend_timeout(self, timeout=DEFAULT_TIMEOUT): """ Memcached deals with long (> 30 days) timeouts in a special way. Call this function to obtain a safe value for your timeout. """ if timeout == DEFAULT_TIMEOUT: timeout = self.default_timeout
- [e4f6182c] def get_many(self, keys, version=None): key_map = { self.make_and_validate_key(key, version=version): key for key in keys } ret = self._cache.get_multi(key_map.keys()) return {key_map[k]: v for k, v in ret.items()}
- [31410d3a] def incr(self, key, delta=1, version=None): key = self.make_and_validate_key(key, version=version) try: # Memcached doesn't support negative delta. if delta < 0: val = self._cache.decr(key, -delta) else: val = self._cache.incr(key, delta) # Normalize an exception raised by the underlying client library to # ValueError in the event of a nonexistent key when calling # incr()/decr(). except self.LibraryValueNotFoundException: val = None if val is None: raise ValueError("Key '%s' not found" % key) return val
- [054dfe4c] def set(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) if not self._cache.set(key, value, self.get_backend_timeout(timeout)): # Make sure the key doesn't keep its old value in case of failure # to set (memcached's 1MB limit). self._cache.delete(key)
- [231e333c] def set_many(self, data, timeout=DEFAULT_TIMEOUT, version=None): safe_data = {} original_keys = {} for key, value in data.items(): safe_key = self.make_and_validate_key(key, version=version) safe_data[safe_key] = value original_keys[safe_key] = key failed_keys = self._cache.set_multi( safe_data, self.get_backend_timeout(timeout) ) return [original_keys[k] for k in failed_keys]
- [9bd4c743] def touch(self, key, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) if timeout == 0: return self._cache.delete(key) return self._cache.touch(key, self.get_backend_timeout(timeout))
- [d020544d] def touch(self, key, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) return bool(self._cache.touch(key, self.get_backend_timeout(timeout)))
- [7c623e91] def validate_key(self, key): for warning in memcache_key_warnings(key): raise InvalidCacheKey(warning)
- [1fc1f611] class BaseMemcachedCache(BaseCache): def __init__(self, server, params, library, value_not_found_exception): super().__init__(params) if isinstance(server, str): self._servers = re.split("[;,]", server) else: self._servers = server
- [8bb402a4] class PyLibMCCache(BaseMemcachedCache): "An implementation of a cache binding using pylibmc"
- [2d83c8e2] class PyMemcacheCache(BaseMemcachedCache): """An implementation of a cache binding using pymemcache."""
- [b03976dd] from django.core.cache.backends.base import ( DEFAULT_TIMEOUT, BaseCache, InvalidCacheKey, memcache_key_warnings, ) from django.utils.functional import cached_property
- [858b9d72] import re import time

# django/core/cache/backends/memcached

- Subject: django/core/cache/backends/memcached (id `dc192038-2e81-422a-b6f4-7575744dd167`)
- Kind: subject
- Budget: 1200 tokens
- Used: 885 tokens
- Facts shown: 19 of 32
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

13 more facts did not fit in the budget: [2c46c9f6] [e4f6182c] [31410d3a] [054dfe4c] [231e333c] [9bd4c743] [d020544d] [7c623e91] [1fc1f611] [8bb402a4] [2d83c8e2] [b03976dd] [858b9d72]

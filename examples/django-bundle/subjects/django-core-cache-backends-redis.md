# django/core/cache/backends/redis

- Subject: django/core/cache/backends/redis (id `fb82d3dd-251d-4a8f-9e7d-696bb1ad154f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 21 of 45
- Conflicts: 0
- Gaps: 0

## Facts

- if isinstance(parser_class, str): parser_class = import_string(parser_class) parser_class = parser_class or self._lib.connection.DefaultParser [186faa58]
- if isinstance(pool_class, str): pool_class = import_string(pool_class) self._pool_class = pool_class or self._lib.ConnectionPool [8bc18b75]
- if isinstance(serializer, str): serializer = import_string(serializer) if callable(serializer): serializer = serializer() self._serializer = serializer or RedisSerializer() [23b2b3ab]
- if timeout == 0: if ret := bool(client.set(key, value, nx=True)): client.delete(key) return ret else: return bool(client.set(key, value, ex=timeout, nx=True)) [d89e2d35]
- if timeout is not None: # Setting timeout for each key as redis does not support timeout # with mset(). for key in data: pipeline.expire(key, timeout) pipeline.execute() [444a24c2]
- self._class = RedisCacheClient self._options = params.get("OPTIONS", {}) [88ea7707]
- self._client = self._lib.Redis [52d511e7]
- self._lib = redis self._servers = servers self._pools = {} [c862b1e9]
- self._pool_options = { "parser_class": parser_class, **driver_info_options, **options, } [7fd7f116]
- version = django.get_version() if hasattr(self._lib, "DriverInfo"): driver_info = self._lib.DriverInfo().add_upstream_driver("django", version) driver_info_options = {"driver_info": driver_info} else: # DriverInfo is not available in this redis-py version. driver_info_options = {"lib_name": f"redis-py(django_v{version})"} [456c3c86]
- @cached_property def _cache(self): return self._class(self._servers, **self._options) [eae694b3]
- def _get_connection_pool(self, write): index = self._get_connection_pool_index(write) if index not in self._pools: self._pools[index] = self._pool_class.from_url( self._servers[index], **self._pool_options, ) return self._pools[index] [b506b907]
- def _get_connection_pool_index(self, write): # Write to the first server. Read from other servers if there are more, # otherwise read from the first server. if write or len(self._servers) == 1: return 0 return random.randint(1, len(self._servers) - 1) [779a7fc1]
- def add(self, key, value, timeout): client = self.get_client(key, write=True) value = self._serializer.dumps(value) [f1829410]
- def add(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.add(key, value, self.get_backend_timeout(timeout)) [18c0ef7c0b3932df-2]
- def clear(self): client = self.get_client(None, write=True) return bool(client.flushdb()) [8509f274]
- def clear(self): return self._cache.clear() [e66fd922]
- def delete(self, key): client = self.get_client(key, write=True) return bool(client.delete(key)) [16cc850d]
- def delete(self, key, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.delete(key) [803d9c45]
- def delete_many(self, keys): client = self.get_client(None, write=True) client.delete(*keys) [8e3af3df]
- """Redis cache backend.""" [3f7d1fa6]

## Beyond the budget

24 more facts did not fit in the budget: [7d21be91] [3b40c6ba] [409bb004] [1b1c3e7ac0a1ff09-2] [a96508bc] [617827f1] [09d8ec03] [1ac0dba6] [5c0ca265] [ac2f009e] [60b2cfd4] [b9000864] [d38dfd71] [97e56cbf] [8ea419b0] [21a6b81d] [20c4b068] [2b41113f] [16d63d07] [ce608f96] [b424d88b] [9b3f1cdd] [3cd39e8d] [f73c4ac7]

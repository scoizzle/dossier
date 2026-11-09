# django/core/cache/backends/redis

- Subject: django/core/cache/backends/redis (id `85701b77-717f-4827-8083-0902241c7b9a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2200 tokens
- Facts shown: 45 of 45
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [7d21be91] def delete_many(self, keys, version=None): if not keys: return safe_keys = [self.make_and_validate_key(key, version=version) for key in keys] self._cache.delete_many(safe_keys)
- [3b40c6ba] def dumps(self, obj): # For better incr() and decr() atomicity, don't pickle integers. # Using type() rather than isinstance() matches only integers and not # subclasses like bool. if type(obj) is int: return obj return pickle.dumps(obj, self.protocol)
- [409bb004] def get(self, key, default): client = self.get_client(key) value = client.get(key) return default if value is None else self._serializer.loads(value)
- [1b1c3e7ac0a1ff09-2] def get(self, key, default=None, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.get(key, default)
- [a96508bc] def get_backend_timeout(self, timeout=DEFAULT_TIMEOUT): if timeout == DEFAULT_TIMEOUT: timeout = self.default_timeout # The key will be made persistent if None used as a timeout. # Non-positive values will cause the key to be deleted. return None if timeout is None else max(0, int(timeout))
- [617827f1] def get_client(self, key=None, *, write=False): # key is used so that the method signature remains the same and custom # cache client can be implemented which might require the key to select # the server, e.g. sharding. pool = self._get_connection_pool(write) return self._client(connection_pool=pool)
- [09d8ec03] def get_many(self, keys): client = self.get_client(None) ret = client.mget(keys) return { k: self._serializer.loads(v) for k, v in zip(keys, ret) if v is not None }
- [1ac0dba6] def get_many(self, keys, version=None): key_map = { self.make_and_validate_key(key, version=version): key for key in keys } ret = self._cache.get_many(key_map.keys()) return {key_map[k]: v for k, v in ret.items()}
- [5c0ca265] def has_key(self, key): client = self.get_client(key) return bool(client.exists(key))
- [ac2f009e] def has_key(self, key, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.has_key(key)
- [60b2cfd4] def incr(self, key, delta): client = self.get_client(key, write=True) if not client.exists(key): raise ValueError("Key '%s' not found." % key) return client.incr(key, delta)
- [b9000864] def incr(self, key, delta=1, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.incr(key, delta)
- [d38dfd71] def loads(self, data): try: return int(data) except ValueError: return pickle.loads(data)
- [97e56cbf] def set(self, key, value, timeout): client = self.get_client(key, write=True) value = self._serializer.dumps(value) if timeout == 0: client.delete(key) else: client.set(key, value, ex=timeout)
- [8ea419b0] def set(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) self._cache.set(key, value, self.get_backend_timeout(timeout))
- [21a6b81d] def set_many(self, data, timeout): client = self.get_client(None, write=True) pipeline = client.pipeline() pipeline.mset({k: self._serializer.dumps(v) for k, v in data.items()})
- [20c4b068] def set_many(self, data, timeout=DEFAULT_TIMEOUT, version=None): if not data: return [] safe_data = {} for key, value in data.items(): key = self.make_and_validate_key(key, version=version) safe_data[key] = value self._cache.set_many(safe_data, self.get_backend_timeout(timeout)) return []
- [2b41113f] def touch(self, key, timeout): client = self.get_client(key, write=True) if timeout is None: return bool(client.persist(key)) else: return bool(client.expire(key, timeout))
- [16d63d07] def touch(self, key, timeout=DEFAULT_TIMEOUT, version=None): key = self.make_and_validate_key(key, version=version) return self._cache.touch(key, self.get_backend_timeout(timeout))
- [ce608f96] class RedisCache(BaseCache): def __init__(self, server, params): super().__init__(params) if isinstance(server, str): self._servers = re.split("[;,]", server) else: self._servers = server
- [b424d88b] class RedisCacheClient: def __init__( self, servers, serializer=None, pool_class=None, parser_class=None, **options, ): import redis
- [9b3f1cdd] class RedisSerializer: def __init__(self, protocol=None): self.protocol = pickle.HIGHEST_PROTOCOL if protocol is None else protocol
- [3cd39e8d] import django from django.core.cache.backends.base import DEFAULT_TIMEOUT, BaseCache from django.utils.functional import cached_property from django.utils.module_loading import import_string
- [f73c4ac7] import pickle import random import re

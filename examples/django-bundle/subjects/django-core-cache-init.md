# django/core/cache/__init__

- Subject: django/core/cache/__init__ (id `c5e8a661-ec01-4a37-b0ed-05a07e67b06d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 574 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- def create_connection(self, alias): params = self.settings[alias].copy() backend = params.pop("BACKEND") location = params.pop("LOCATION", "") try: backend_cls = import_string(backend) except ImportError as e: raise InvalidCacheBackendError( "Could not find backend '%s': %s" % (backend, e) ) from e return backend_cls(location, params) [1772c540]
- """ Caching framework. [c86c3efc]
- Client code should use the `cache` variable defined here to access the default cache backend and look up non-default cache backends in the `caches` dict-like object. [1c95e3bb]
- DEFAULT_CACHE_ALIAS = "default" [ff26e531]
- See docs/topics/cache.txt for information on the public API. """ [52338824]
- This package defines set of cache backends that all conform to a simple API. In a nutshell, a cache is a set of values -- which can be any object that may be pickled -- identified by string keys. For the complete API, see the abstract BaseCache class in django.core.cache.backends.base. [fa6f9930]
- __all__ = [ "cache", "caches", "DEFAULT_CACHE_ALIAS", "InvalidCacheBackendError", "CacheKeyWarning", "BaseCache", "InvalidCacheKey", ] [e00c88fd]
- cache = ConnectionProxy(caches, DEFAULT_CACHE_ALIAS) [f0f7ec8a]
- caches = CacheHandler() [c0d2c050]
- class CacheHandler(BaseConnectionHandler): settings_name = "CACHES" exception_class = InvalidCacheBackendError [de017d8b]
- def close_caches(**kwargs): # Some caches need to do a cleanup at the end of a request cycle. If not # implemented in a particular backend cache.close() is a no-op. caches.close_all() [740be916]
- from django.core import signals from django.core.cache.backends.base import ( BaseCache, CacheKeyWarning, InvalidCacheBackendError, InvalidCacheKey, ) from django.utils.connection import BaseConnectionHandler, ConnectionProxy from django.utils.module_loading import import_string [d2eccac8]
- signals.request_finished.connect(close_caches) [1704473b]

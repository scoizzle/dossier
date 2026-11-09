# django/core/files/storage/handler

- Subject: django/core/files/storage/handler (id `fd89680c-ebea-4cb0-b7e2-c2d292817b49`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 361 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def backends(self): if self._backends is None: self._backends = settings.STORAGES.copy() return self._backends [8098c152]
- def __getitem__(self, alias): try: return self._storages[alias] except KeyError: try: params = self.backends[alias] except KeyError: raise InvalidStorageError( f"Could not find config for '{alias}' in settings.STORAGES." ) storage = self.create_storage(params) self._storages[alias] = storage return storage [a3390c14]
- def create_storage(self, params): params = params.copy() backend = params.pop("BACKEND") options = params.pop("OPTIONS", {}) try: storage_cls = import_string(backend) except ImportError as e: raise InvalidStorageError(f"Could not find backend {backend!r}: {e}") from e return storage_cls(**options) [2ac07c87]
- class InvalidStorageError(ImproperlyConfigured): pass [8dfc4341]
- class StorageHandler: def __init__(self, backends=None): # backends is an optional dict of storage backend definitions # (structured like settings.STORAGES). self._backends = backends self._storages = {} [34f1136f]
- from django.conf import settings from django.core.exceptions import ImproperlyConfigured from django.utils.functional import cached_property from django.utils.module_loading import import_string [9e45e42a]

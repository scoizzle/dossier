# django/core/files/storage/__init__

- Subject: django/core/files/storage/__init__ (id `76c69508-4184-4605-8bdf-4a491a04a2e2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 196 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- __all__ = ( "FileSystemStorage", "InMemoryStorage", "Storage", "DefaultStorage", "default_storage", "InvalidStorageError", "StorageHandler", "storages", ) [8d874b81]
- class DefaultStorage(LazyObject): def _setup(self): self._wrapped = storages[DEFAULT_STORAGE_ALIAS] [506db902]
- from .base import Storage from .filesystem import FileSystemStorage from .handler import InvalidStorageError, StorageHandler from .memory import InMemoryStorage [d0decbd3]
- from django.conf import DEFAULT_STORAGE_ALIAS from django.utils.functional import LazyObject [517e384f]
- storages = StorageHandler() default_storage = DefaultStorage() [41a63505]

# django/core/files/storage/__init__

- Subject: django/core/files/storage/__init__ (id `d5a48d91-ad15-406b-a146-18cd1049a042`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 196 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- __all__ = ( "FileSystemStorage", "InMemoryStorage", "Storage", "DefaultStorage", "default_storage", "InvalidStorageError", "StorageHandler", "storages", ) [8d874b81]
- class DefaultStorage(LazyObject): def _setup(self): self._wrapped = storages[DEFAULT_STORAGE_ALIAS] [506db902]
- from .base import Storage from .filesystem import FileSystemStorage from .handler import InvalidStorageError, StorageHandler from .memory import InMemoryStorage [d0decbd3]
- from django.conf import DEFAULT_STORAGE_ALIAS from django.utils.functional import LazyObject [517e384f]
- storages = StorageHandler() default_storage = DefaultStorage() [41a63505]

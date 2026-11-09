# django/core/cache/backends/dummy

- Subject: django/core/cache/backends/dummy (id `401ac6fc-f52f-4e5d-bb67-a4daf896b33c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 329 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def add(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): self.make_and_validate_key(key, version=version) return True [e06a7a66]
- def clear(self): pass [35a6a56d]
- def delete(self, key, version=None): self.make_and_validate_key(key, version=version) return False [5dc52022]
- def get(self, key, default=None, version=None): self.make_and_validate_key(key, version=version) return default [b0c784b1]
- def has_key(self, key, version=None): self.make_and_validate_key(key, version=version) return False [28a71b54]
- def set(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): self.make_and_validate_key(key, version=version) [2b72bbe0]
- def touch(self, key, timeout=DEFAULT_TIMEOUT, version=None): self.make_and_validate_key(key, version=version) return False [32a0621e]
- "Dummy cache backend" [ce323e5c]
- class DummyCache(BaseCache): def __init__(self, host, *args, **kwargs): super().__init__(*args, **kwargs) [09713219]
- from django.core.cache.backends.base import DEFAULT_TIMEOUT, BaseCache [202de63835ade9f6]

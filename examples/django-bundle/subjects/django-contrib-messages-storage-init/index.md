# django/contrib/messages/storage/__init__

- Subject: django/contrib/messages/storage/__init__ (id `9a50b473-3b97-4bc4-8770-f1a23fd6e9b9`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 122 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- This isn't just default_storage = import_string(settings.MESSAGE_STORAGE) to avoid accessing the settings at the module level. """ return import_string(settings.MESSAGE_STORAGE)(request) [b57ee610]
- def default_storage(request): """ Callable with the same interface as the storage classes. [a8e6fab9]
- from django.conf import settings from django.utils.module_loading import import_string [c2cf27e6]

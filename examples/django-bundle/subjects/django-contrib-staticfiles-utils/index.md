# django/contrib/staticfiles/utils

- Subject: django/contrib/staticfiles/utils (id `b19e1360-66ff-4a08-a95b-b055ec60e91c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 517 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def check_settings(base_url=None): """ Check if the staticfiles settings have sane values. """ if base_url is None: base_url = settings.STATIC_URL if not base_url: raise ImproperlyConfigured( "You're using the staticfiles app " "without having set the required STATIC_URL setting." ) if settings.MEDIA_URL == base_url: raise ImproperlyConfigured( "The MEDIA_URL and STATIC_URL settings must have different values" ) if ( settings.DEBUG and settings.MEDIA_URL and settings.STATIC_URL and settings.MEDIA_URL.startswith(settings.STATIC_URL) ): raise ImproperlyConfigured( "runserver can't serve media if MEDIA_URL is within STATIC_URL." ) if (settings.MEDIA_ROOT and settings.STATIC_ROOT) and ( settings.MEDIA_ROOT == settings.STATIC_ROOT ): raise ImproperlyConfigured( "The MEDIA_ROOT and STATIC_ROOT settings must have different values" ) [c23e5943]
- def get_files(storage, ignore_patterns=None, location=""): """ Recursively walk the storage directories yielding the paths of all files that should be copied. """ if ignore_patterns is None: ignore_patterns = [] directories, files = storage.listdir(location) for fn in files: # Match only the basename. if matches_patterns(fn, ignore_patterns): continue if location: fn = os.path.join(location, fn) # Match the full file path. if matches_patterns(fn, ignore_patterns): continue yield fn for dir in directories: if matches_patterns(dir, ignore_patterns): continue if location: dir = os.path.join(location, dir) yield from get_files(storage, ignore_patterns, dir) [85251e9f]
- def matches_patterns(path, patterns): """ Return True or False depending on whether the ``path`` should be ignored (if it matches any pattern in ``ignore_patterns``). """ return any(fnmatch.fnmatchcase(path, pattern) for pattern in patterns) [3fb1a939]
- from django.conf import settings from django.core.exceptions import ImproperlyConfigured [1af0304e183f826c]
- import fnmatch import os [437e71cc]

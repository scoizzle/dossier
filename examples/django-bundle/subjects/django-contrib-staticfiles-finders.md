# django/contrib/staticfiles/finders

- Subject: django/contrib/staticfiles/finders (id `d3b26a01-d3ad-4776-82f6-74c248d6d0e2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 9 of 32
- Conflicts: 0
- Gaps: 0

## Facts

- If the ``find_all`` parameter is False (default) return only the first found file path; if True, return a list of all found files paths. """ raise NotImplementedError( "subclasses of BaseFinder must provide a find() method" ) [a5ca914c]
- If ``find_all`` is ``False`` (default), return the first matching absolute path (or ``None`` if no match). Otherwise return a list. """ searched_locations[:] = [] matches = [] for finder in get_finders(): result = finder.find(path, find_all=find_all) if not find_all and result: return result if not isinstance(result, (list, tuple)): result = [result] matches.extend(result) if matches: return matches # No match. return [] if find_all else None [cd9f6b72]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) base_location = getattr(self.storage, "base_location", empty) if not base_location: raise ImproperlyConfigured( "The storage backend of the " "staticfiles finder %r doesn't have " "a valid location." % self.__class__ ) [7d48d12b]
- def __init__(self, app_names=None, *args, **kwargs): # List of locations with static files self.locations = [] # Maps dir paths to an appropriate storage instance self.storages = {} for root in settings.STATICFILES_DIRS: if isinstance(root, (list, tuple)): prefix, root = root else: prefix = "" if (prefix, root) not in self.locations: self.locations.append((prefix, root)) for prefix, root in self.locations: filesystem_storage = FileSystemStorage(location=root) filesystem_storage.prefix = prefix self.storages[root] = filesystem_storage super().__init__(*args, **kwargs) [470d6a42]
- def __init__(self, app_names=None, *args, **kwargs): # The list of apps that are handled self.apps = [] # Mapping of app names to storage instances self.storages = {} app_configs = apps.get_app_configs() if app_names: app_names = set(app_names) app_configs = [ac for ac in app_configs if ac.name in app_names] for app_config in app_configs: app_storage = self.storage_class( os.path.join(app_config.path, self.source_dir) ) if os.path.isdir(app_storage.location): self.storages[app_config.name] = app_storage if app_config.name not in self.apps: self.apps.append(app_config.name) super().__init__(*args, **kwargs) [9405c7d6]
- def __init__(self, storage=None, *args, **kwargs): if storage is not None: self.storage = storage if self.storage is None: raise ImproperlyConfigured( "The staticfiles storage finder %r " "doesn't have a storage class " "assigned." % self.__class__ ) # Make sure we have a storage instance here. if not isinstance(self.storage, (Storage, LazyObject)): self.storage = self.storage() super().__init__(*args, **kwargs) [c1fbef0b]
- def check(self, **kwargs): raise NotImplementedError( "subclasses may provide a check() method to verify the finder is " "configured correctly." ) [e50bfa48]
- def find(self, path, find_all=False): """ Given a relative file path, find an absolute file path. [60f56eb6]
- def find(self, path, find_all=False): """ Look for files in the app directories. """ matches = [] for app in self.apps: app_location = self.storages[app].location if app_location not in searched_locations: searched_locations.append(app_location) match = self.find_in_app(app, path) if match: if not find_all: return match matches.append(match) return matches [dd6a2a36]

## Beyond the budget

23 more facts did not fit in the budget: [8a8d184d] [7a1c565e] [81f260ce] [060c402b] [60119882] [13c0f162] [e9ab81b7] [0930d3bf] [2466c96c] [b9063f5f] [50f010e5] [6cf3d68e] [95bd5227] [ff498666] [a5b1ef8a] [1705c605] [64912fac] [519f945e] [5c935e7d] [8f03611e] [e70432d6] [2bc27306] [0d7a9619]

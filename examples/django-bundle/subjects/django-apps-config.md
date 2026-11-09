# django/apps/config

- Subject: django/apps/config (id `1a314687-5900-40e5-bad3-b9137c2e0fac`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 10 of 35
- Conflicts: 0
- Gaps: 0

## Facts

- # Use the default app config class if we didn't find anything. if app_config_class is None: app_config_class = cls app_name = entry [8870d749]
- # Check for obvious errors. (This check prevents duck typing, but # it could be removed if it became a problem in practice.) if not issubclass(app_config_class, AppConfig): raise ImproperlyConfigured("'%s' isn't a subclass of AppConfig." % entry) [b6252eed]
- # Ensure app_name points to a valid module. try: app_module = import_module(app_name) except ImportError: raise ImproperlyConfigured( "Cannot import '%s'. Check that '%s.%s.name' is correct." % ( app_name, app_config_class.__module__, app_config_class.__qualname__, ) ) [ae6b6f17]
- # Entry is a path to an app config class. return app_config_class(app_name, app_module) [5f33aec8]
- # Filesystem path to the application directory e.g. # '/path/to/django/contrib/admin'. if not hasattr(self, "path"): self.path = self._path_from_module(app_module) [e2dd84da]
- # Human-readable name for the application e.g. "Admin". if not hasattr(self, "verbose_name"): self.verbose_name = self.label.title() [cc0a42eb]
- # If import_module succeeds, entry points to the app module. try: app_module = import_module(entry) except Exception: pass else: # If app_module has an apps submodule that defines a single # AppConfig subclass, use it automatically. # To prevent this, an AppConfig subclass can declare a class # variable default = False. # If the apps module defines more than one AppConfig subclass, # the default one can declare default = True. if module_has_submodule(app_module, APPS_MODULE_NAME): mod_path = "%s.%s" % (entry, APPS_MODULE_NAME) mod = import_module(mod_path) # Check if there's exactly one AppConfig candidate, # excluding those that explicitly define default = False. app_configs = [ (name, candidate) for name, candidate in inspect.getmembers(mod, inspect.isclass) if ( issubclass(candidate, cls) and candidate is not cls and getattr(candidate, "default", True) ) ] if len(app_configs) == 1: app_config_class = app_configs[0][1] else: # Check if there's exactly one AppConfig subclass, # among those that explicitly define default = True. app_configs = [ (name, candidate) for name, candidate in app_configs if getattr(candidate, "default", False) ] if len(app_configs) > 1: candidates = [repr(name) for name, _ in app_configs] raise RuntimeError( "%r declares more than one default AppConfig: " "%s." % (mod_path, ", ".join(candidates)) ) elif len(app_configs) == 1: app_config_class = app_configs[0][1] [bfc26a08]
- # Last component of the Python path to the application e.g. 'admin'. # This value must be unique across a Django project. if not hasattr(self, "label"): self.label = app_name.rpartition(".")[2] if not self.label.isidentifier(): raise ImproperlyConfigured( "The app label '%s' is not a valid Python identifier." % self.label ) [86063d25]
- # Mapping of lowercase model names to model classes. Initially set to # None to prevent accidental access before import_models() runs. self.models = None [fdf60eba]
- # Module containing models e.g. <module 'django.contrib.admin.models' # from 'django/contrib/admin/models.py'>. Set by import_models(). # None if the application doesn't have a models module. self.models_module = None [afc240c8]

## Beyond the budget

25 more facts did not fit in the budget: [740700a8] [543a90aa] [023bf069] [9c4c1445] [db875692] [d5df7040777fbcfe] [fbac367176154586] [9e7025b2] [5d5895bf] [0afa07e4] [a86ae0da] [735f0f6e] [c7456ea3] [2c8d281b] [157dfab5] [94616256] [be615ddb] [617b7ebf] [f609abbe] [7d29b276] [9a18cf32] [e83b7a85] [9eee9110] [358afed4] [73659330]

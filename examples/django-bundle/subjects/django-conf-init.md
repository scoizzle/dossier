# django/conf/__init__

- Subject: django/conf/__init__ (id `14429723-cde1-441a-8e75-156e546c7bba`)
- Kind: subject
- Budget: 1200 tokens
- Used: 885 tokens
- Facts shown: 10 of 53
- Conflicts: 0
- Gaps: 0

## Facts

- if setting in tuple_settings and not isinstance( setting_value, (list, tuple) ): raise ImproperlyConfigured( "The %s setting must be a list or a tuple." % setting ) setattr(self, setting, setting_value) self._explicit_settings.add(setting) [ba6e9d22]
- # RemovedInDjango2028Warning. _check_email_settings_conflicts(options.keys()) [fcb0e8d6]
- # RemovedInDjango2028Warning. if "SIGNED_COOKIE_LEGACY_SALT_FALLBACK" in self._explicit_settings: warnings.warn( SIGNED_COOKIE_LEGACY_SALT_DEPRECATED_MSG, RemovedInDjango2028Warning, skip_file_prefixes=django_file_prefixes(), ) # RemovedInDjango2028Warning. if "USE_BLANK_CHOICE_DASH" in self._explicit_settings: warnings.warn( USE_BLANK_CHOICE_DASH_DEPRECATED_MSG, RemovedInDjango2028Warning, skip_file_prefixes=django_file_prefixes(), ) # RemovedInDjango2028Warning. _check_email_settings_conflicts(self._explicit_settings) for name in DEPRECATED_EMAIL_SETTINGS.intersection(self._explicit_settings): warnings.warn( EMAIL_SETTING_DEPRECATED_MSG.format(name=name), RemovedInDjango2028Warning, skip_file_prefixes=django_file_prefixes(), ) [a39ab90b]
- # RemovedInDjango2028Warning. if name == "SIGNED_COOKIE_LEGACY_SALT_FALLBACK": _show_settings_deprecation_warning( SIGNED_COOKIE_LEGACY_SALT_DEPRECATED_MSG, RemovedInDjango2028Warning, ) # RemovedInDjango2028Warning. if name == "USE_BLANK_CHOICE_DASH": _show_settings_deprecation_warning( USE_BLANK_CHOICE_DASH_DEPRECATED_MSG, RemovedInDjango2028Warning ) # RemovedInDjango2028Warning. if name == "MAILERS": # When MAILERS is set, clear any cached values of # deprecated settings so that __getattr__() runs again for them. for setting in DEPRECATED_EMAIL_SETTINGS: self.__dict__.pop(setting, None) if name in DEPRECATED_EMAIL_SETTINGS: _show_settings_deprecation_warning( EMAIL_SETTING_DEPRECATED_MSG.format(name=name), RemovedInDjango2028Warning, ) [b5df530b]
- # RemovedInDjango2028Warning. if name in DEPRECATED_EMAIL_SETTINGS: if hasattr(_wrapped, "MAILERS"): raise AttributeError( f"The {name} setting is not available when MAILERS is defined." ) _show_settings_deprecation_warning( EMAIL_SETTING_DEPRECATED_MSG.format(name=name), RemovedInDjango2028Warning, ) [6f6948da]
- # Special case some settings which require further modification. # This is done here for performance reasons so the modified value is # cached. if name in {"MEDIA_URL", "STATIC_URL"} and val is not None: val = self._add_script_prefix(val) elif name == "SECRET_KEY" and not val: raise ImproperlyConfigured("The SECRET_KEY setting must not be empty.") [53b144a8]
- # store the settings module in case someone later cares self.SETTINGS_MODULE = settings_module [432b162e]
- Useful when the app is being served at a subpath and manually prefixing subpath to STATIC_URL and MEDIA_URL in settings is inconvenient. """ # Don't apply prefix to absolute paths and URLs. if value.startswith(("http://", "https://", "/")): return value from django.urls import get_script_prefix [14e871f0]
- holder = UserSettingsHolder(default_settings) for name, value in options.items(): if not name.isupper(): raise TypeError("Setting %r must be uppercase." % name) setattr(holder, name, value) self._wrapped = holder [87ea097e]
- mod = importlib.import_module(self.SETTINGS_MODULE) [9e93a77b]

## Beyond the budget

42 more facts did not fit in the budget: [0150bb47] [208cc084] [cb62a951] [9374cbb6] [58642ac69aabc72b] [d8fc83bb] [4fd4e1e7] [af83b407] [86facf7a] [7abc2d1b] [bef064f3] [80cc558d] [27bc938e] [b3254a82] [52523370] [dd6e312e] [a64e479d] [c8977bdd] [0f0d55c4] [3fb52cea] [80e20a52] [8ea79681] [8464a5c1] [dee47676] [68ae2e49] [ab632cf4] [c5a740e4] [c25af64c] [315287de] [c68cc6ce] [7a01fcc1] [2ad3c7d2] [57376737] [1bc55b01] [678960b9] [187c065f] [a6eff721] [e3866edf] [05af385e] [c2b86f1f] [23796caf] [8cb74e11]

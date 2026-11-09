# django/template/utils

- Subject: django/template/utils (id `8c69f1e4-a8f4-468f-ac24-9baf50a9de88`)
- Kind: subject
- Budget: 1200 tokens
- Used: 856 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- # If importing or initializing the backend raises an exception, # self._engines[alias] isn't set and this code may get executed # again, so we must preserve the original params. See #24265. params = params.copy() backend = params.pop("BACKEND") engine_cls = import_string(backend) engine = engine_cls(params) [0ded0954]
- self._engines[alias] = engine return engine [1b5547f1]
- templates[tpl["NAME"]] = tpl backend_names.append(tpl["NAME"]) [b8117089]
- tpl = { "NAME": default_name, "DIRS": [], "APP_DIRS": False, "OPTIONS": {}, **tpl, } [bbfafc1b]
- counts = Counter(backend_names) duplicates = [alias for alias, count in counts.most_common() if count > 1] if duplicates: raise ImproperlyConfigured( "Template engine aliases aren't unique, duplicates: {}. " "Set a unique NAME for each engine in settings.TEMPLATES.".format( ", ".join(duplicates) ) ) [ef5af0c3]
- return templates [60aa0185]
- templates = {} backend_names = [] for tpl in self._templates: try: # This will raise an exception if 'BACKEND' doesn't exist or # isn't a string containing at least one dot. default_name = tpl["BACKEND"].rsplit(".", 2)[-2] except Exception: invalid_backend = tpl.get("BACKEND", "<not defined>") raise ImproperlyConfigured( "Invalid BACKEND for a template engine: {}. Check " "your TEMPLATES setting.".format(invalid_backend) ) [b82e62d2]
- @cached_property def templates(self): if self._templates is None: self._templates = settings.TEMPLATES [585b5f26]
- def __getitem__(self, alias): try: return self._engines[alias] except KeyError: try: params = self.templates[alias] except KeyError: raise InvalidTemplateEngineError( "Could not find config for '{}' " "in settings.TEMPLATES".format(alias) ) [fb9dd881]
- def __iter__(self): return iter(self.templates) [2776bf31]
- def all(self): return [self[alias] for alias in self] [a4eef439]
- dirname is the name of the subdirectory containing templates inside installed applications. """ # Immutable return value because it will be cached and shared by callers. return tuple( path for app_config in apps.get_app_configs() if app_config.path and (path := Path(app_config.path) / dirname).is_dir() ) [5dc90516]
- @functools.lru_cache def get_app_template_dirs(dirname): """ Return an iterable of paths of directories to load app templates from. [905718cf]
- class EngineHandler: def __init__(self, templates=None): """ templates is an optional list of template engine definitions (structured like settings.TEMPLATES). """ self._templates = templates self._engines = {} [9cfc38cc]
- class InvalidTemplateEngineError(ImproperlyConfigured): pass [f740b173]
- from django.apps import apps from django.conf import settings from django.core.exceptions import ImproperlyConfigured from django.utils.functional import cached_property from django.utils.module_loading import import_string [4762018b]
- import functools from collections import Counter from pathlib import Path [fa3e5805]

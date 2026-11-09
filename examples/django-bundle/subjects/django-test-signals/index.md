# django/test/signals

- Subject: django/test/signals (id `5953c7b8-31f3-48c1-888c-b2ea9cd733f3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2168 tokens
- Facts shown: 53 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- UserModel = get_user_model() except ImproperlyConfigured: # Some tests set an invalid AUTH_USER_MODEL. pass else: from django.contrib.auth import backends [26435257]
- backends.UserModel = UserModel [515e26eb]
- changepassword.UserModel = UserModel [9dcb423a]
- forms.UserModel = UserModel [97f83572]
- from django.contrib.auth import forms [5b218936]
- from django.contrib.auth import views [7ae6dab4]
- from django.contrib.auth.handlers import modwsgi [e499c3f6]
- from django.contrib.auth.management.commands import changepassword [255c5ee7]
- modwsgi.UserModel = UserModel [7d5c7089]
- views.UserModel = UserModel [c24c4348]
- # Reset local time zone cache timezone.get_default_timezone.cache_clear() [6e980f83]
- Engine.get_default.cache_clear() from django.forms.renderers import get_default_renderer [1b4f9e3d]
- clear_url_caches() set_urlconf(None) [92e2f40d]
- close_caches() caches._settings = caches.settings = caches.configure_settings(None) caches._connections = Local() [510a2409]
- default_storage._wrapped = empty staticfiles_storage._wrapped = empty [707e1dae]
- get_app_template_dirs.cache_clear() # Rebuild translations cache. from django.utils.translation import trans_real [28805e70]
- get_commands.cache_clear() # Rebuild get_app_template_dirs cache. from django.template.utils import get_app_template_dirs [7943fa37]
- get_default_password_validators.cache_clear() [2342d453]
- get_default_renderer.cache_clear() [e0569ea4189b07da]
- get_default_renderer.cache_clear() [e0569ea4189b07da-2]
- get_finder.cache_clear() [144b8eed]
- get_finder.cache_clear() # Rebuild management commands cache from django.core.management import get_commands [c438b2dd]
- serializers._serializers = {} [c516843e]
- staticfiles_storage._wrapped = empty [ea68478e]
- trans_real._default = None trans_real._active = Local() if setting in {"LANGUAGES", "LOCALE_PATHS"}: from django.utils.translation import trans_real [dc446031]
- trans_real._translations = {} [f260cb5c]
- trans_real._translations = {} trans_real.translation_catalog_exists.cache_clear() [89ecce50]
- try: del engines.templates except AttributeError: pass engines._templates = None engines._engines = {} from django.template.engine import Engine [7f15fda1]
- # Reset the database connections' time zone if setting in {"TIME_ZONE", "USE_TZ"}: for conn in connections.all(initialized_only=True): try: del conn.timezone except AttributeError: pass try: del conn.timezone_name except AttributeError: pass conn.ensure_timezone() [d8cbc03e]
- if setting in ( "STORAGES", "STATIC_ROOT", "STATIC_URL", ): try: del storages.backends except AttributeError: pass storages._backends = None storages._storages = {} [27471d46]

## All facts

- [b8c35fd5] # Most setting_changed receivers are supposed to be added below, # except for cases where the receiver is related to a contrib app.
- [f9260ef3] # Settings that may not work well when using 'override_settings' (#19031) COMPLEX_OVERRIDE_SETTINGS = {"DATABASES"}
- [bfb3f9ba] @receiver(setting_changed) def auth_password_validators_changed(*, setting, **kwargs): if setting == "AUTH_PASSWORD_VALIDATORS": from django.contrib.auth.password_validation import ( get_default_password_validators, )
- [26320711] @receiver(setting_changed) def clear_cache_handlers(*, setting, **kwargs): if setting == "CACHES": from django.core.cache import caches, close_caches
- [cb649c9c] @receiver(setting_changed) def clear_routers_cache(*, setting, **kwargs): if setting == "DATABASE_ROUTERS": router.routers = ConnectionRouter().routers
- [fca46d50] @receiver(setting_changed) def clear_serializers_cache(*, setting, **kwargs): if setting == "SERIALIZATION_MODULES": from django.core import serializers
- [ff3cee63] @receiver(setting_changed) def complex_setting_changed(*, enter, setting, **kwargs): if enter and setting in COMPLEX_OVERRIDE_SETTINGS: # Considering the current implementation of the signals framework, # this stacklevel shows the line containing the override_settings call. warnings.warn( f"Overriding setting {setting} can lead to unexpected behavior.", stacklevel=5, )
- [4a472f2c] @receiver(setting_changed) def form_renderer_changed(*, setting, **kwargs): if setting == "FORM_RENDERER": from django.forms.renderers import get_default_renderer
- [6975c9a8] @receiver(setting_changed) def language_changed(*, setting, **kwargs): if setting in {"LANGUAGES", "LANGUAGE_CODE", "LOCALE_PATHS"}: from django.utils.translation import trans_real
- [2eb4ba9f] @receiver(setting_changed) def localize_settings_changed(*, setting, **kwargs): if setting in FORMAT_SETTINGS or setting == "USE_THOUSAND_SEPARATOR": reset_format_cache()
- [28622aba] @receiver(setting_changed) def reset_template_engines(*, setting, **kwargs): if setting in { "TEMPLATES", "DEBUG", "INSTALLED_APPS", }: from django.template import engines
- [42abdcf4] @receiver(setting_changed) def root_urlconf_changed(*, setting, **kwargs): if setting == "ROOT_URLCONF": from django.urls import clear_url_caches, set_urlconf
- [c341987b] @receiver(setting_changed) def static_finders_changed(*, setting, **kwargs): if setting in { "STATICFILES_DIRS", "STATIC_ROOT", }: from django.contrib.staticfiles.finders import get_finder
- [e70839e6] @receiver(setting_changed) def static_storage_changed(*, setting, **kwargs): if setting in { "STATIC_ROOT", "STATIC_URL", }: from django.contrib.staticfiles.storage import staticfiles_storage
- [fb84e0c9] @receiver(setting_changed) def storages_changed(*, setting, **kwargs): from django.contrib.staticfiles.storage import staticfiles_storage from django.core.files.storage import default_storage, storages
- [cdfaea96] @receiver(setting_changed) def update_connections_time_zone(*, setting, **kwargs): if setting == "TIME_ZONE": # Reset process time zone if hasattr(time, "tzset"): if kwargs["value"]: os.environ["TZ"] = kwargs["value"] else: os.environ.pop("TZ", None) time.tzset()
- [d282a656] @receiver(setting_changed) def update_installed_apps(*, setting, **kwargs): if setting == "INSTALLED_APPS": # Rebuild any AppDirectoriesFinder instance. from django.contrib.staticfiles.finders import get_finder
- [ebae3b9b] @receiver(setting_changed) def update_logging_config(*, setting, **kwargs): if setting in {"LOGGING", "LOGGING_CONFIG"}: configure_logging(settings.LOGGING_CONFIG, settings.LOGGING)
- [d0edb55b] @receiver(setting_changed) def user_model_swapped(*, setting, **kwargs): if setting == "AUTH_USER_MODEL": apps.clear_cache() try: from django.contrib.auth import get_user_model
- [6beab4e4549a99b7-2] from asgiref.local import Local
- [a1ad1431] from django.apps import apps from django.conf import settings from django.core.exceptions import ImproperlyConfigured from django.core.signals import setting_changed from django.db import connections, router from django.db.utils import ConnectionRouter from django.dispatch import Signal, receiver from django.utils import timezone from django.utils.formats import FORMAT_SETTINGS, reset_format_cache from django.utils.functional import empty from django.utils.log import configure_logging
- [b91dc666] import os import time import warnings
- [d87db186] template_rendered = Signal()

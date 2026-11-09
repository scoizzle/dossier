# django/test/signals

- Subject: django/test/signals (id `2447b789-02a3-4c61-b8c2-d002470a327f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 30 of 53
- Conflicts: 0
- Gaps: 0

## Facts

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
- from asgiref.local import Local [6beab4e4549a99b7-2]

## Beyond the budget

22 more facts did not fit in the budget: [b8c35fd5] [f9260ef3] [bfb3f9ba] [26320711] [cb649c9c] [fca46d50] [ff3cee63] [4a472f2c] [6975c9a8] [2eb4ba9f] [28622aba] [42abdcf4] [c341987b] [e70839e6] [fb84e0c9] [cdfaea96] [d282a656] [ebae3b9b] [d0edb55b] [a1ad1431] [b91dc666] [d87db186]

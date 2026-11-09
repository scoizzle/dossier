# django/core/mail/handler

- Subject: django/core/mail/handler (id `b4ec63ab-08fc-4be8-85e1-bf792685819e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 734 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- assert _deprecated_kwargs is None return get_connection() [50351ac6]
- # RemovedInDjango2028Warning. if _deprecated_kwargs: # Being called from get_connection() to create default mailer # instance with some overrides. _ignore_unknown_kwargs prevents # BaseEmailBackend from reporting these as unknown OPTIONS. assert alias == DEFAULT_MAILER_ALIAS options = options | _deprecated_kwargs options |= {"_ignore_unknown_kwargs": set(_deprecated_kwargs)} [f6fde24b]
- backend_path = config.get("BACKEND", DEFAULT_MAILER_BACKEND) try: backend_class = import_string(backend_path) except ImportError as error: raise InvalidMailer( f"Could not find BACKEND {backend_path!r}: {error}", alias=alias ) from error return backend_class(alias=alias, **options) [9517b74d]
- options = config.get("OPTIONS", {}) if "alias" in options: raise InvalidMailer("OPTIONS must not define 'alias'.", alias=alias) [a1abebf0]
- try: config = self.settings[alias] except KeyError: raise MailerDoesNotExist(alias=alias) from None [a32d32c7]
- # RemovedInDjango2028Warning. @property def _is_configured(self): """True if settings.py has opted into MAILERS support.""" return hasattr(settings, "MAILERS") [66afaec8]
- # RemovedInDjango2028Warning: _deprecated_kwargs. def create_connection(self, alias, /, *, _deprecated_kwargs=None): # RemovedInDjango2028Warning. if not self._is_configured and alias == DEFAULT_MAILER_ALIAS: # Create mailers.default from deprecated settings. from django.core.mail import get_connection [17174f20]
- @property def default(self): return self[DEFAULT_MAILER_ALIAS] [2afe17ab]
- @property def settings(self): # RemovedInDjango2028Warning: change to: # return settings.MAILERS return getattr(settings, "MAILERS", {}) [82083aed]
- def __contains__(self, /, alias): return alias in self.settings [b8e63cf0]
- def __iter__(self): return iter(self.settings) [c4d417f15a0d4f27]
- def get(self, alias, /, default=None): try: return self[alias] except MailerDoesNotExist: return default [a075a7b2]
- # Default value for a MAILERS "BACKEND". (Not related to the default mailer.) DEFAULT_MAILER_BACKEND = "django.core.mail.backends.smtp.EmailBackend" [51b0000c]
- DEFAULT_MAILER_ALIAS = "default" [bdfdc5c1]
- class MailersHandler: def __getitem__(self, /, alias): return self.create_connection(alias) [93577732]
- from django.conf import settings from django.core.mail import InvalidMailer, MailerDoesNotExist from django.utils.module_loading import import_string [f575063f]

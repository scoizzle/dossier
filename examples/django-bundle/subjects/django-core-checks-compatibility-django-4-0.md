# django/core/checks/compatibility/django_4_0

- Subject: django/core/checks/compatibility/django_4_0 (id `84581163-2232-4a55-a98a-2aa4e805aca8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 145 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- @register(Tags.compatibility) def check_csrf_trusted_origins(app_configs, **kwargs): errors = [] for origin in settings.CSRF_TRUSTED_ORIGINS: if "://" not in origin: errors.append( Error( "As of Django 4.0, the values in the CSRF_TRUSTED_ORIGINS " "setting must start with a scheme (usually http:// or " "https://) but found %s. See the release notes for details." % origin, id="4_0.E001", ) ) return errors [e8eee661]
- from django.conf import settings from django.core.checks import Error, Tags, register [870b8d37]

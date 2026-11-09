# django/contrib/staticfiles/checks

- Subject: django/contrib/staticfiles/checks (id `a47bdc41-2f89-4451-b020-b2a0cebd80da`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 224 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- E005 = Error( f"The STORAGES setting must define a '{STATICFILES_STORAGE_ALIAS}' storage.", id="staticfiles.E005", ) [d6e6f491]
- def check_finders(app_configs, **kwargs): """Check all registered staticfiles finders.""" errors = [] for finder in get_finders(): try: finder_errors = finder.check() except NotImplementedError: pass else: errors.extend(finder_errors) return errors [e12aafa3]
- def check_storages(app_configs, **kwargs): """Ensure staticfiles is defined in STORAGES setting.""" errors = [] if STATICFILES_STORAGE_ALIAS not in settings.STORAGES: errors.append(E005) return errors [b6fc3d07]
- from django.conf import STATICFILES_STORAGE_ALIAS, settings from django.contrib.staticfiles.finders import get_finders from django.core.checks import Error [ccc57f24]

# django/contrib/staticfiles/apps

- Subject: django/contrib/staticfiles/apps (id `ebd314b8-ea21-494b-9dfe-bbb5cb30ea1f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 149 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def ready(self): checks.register(check_finders, checks.Tags.staticfiles) checks.register(check_storages, checks.Tags.staticfiles) [b1e21a87]
- class StaticFilesConfig(AppConfig): name = "django.contrib.staticfiles" verbose_name = _("Static Files") ignore_patterns = ["CVS", ".*", "*~"] [8ded29cb]
- from django.apps import AppConfig from django.contrib.staticfiles.checks import check_finders, check_storages from django.core import checks from django.utils.translation import gettext_lazy as _ [f8fb9076]

# django/contrib/sites/apps

- Subject: django/contrib/sites/apps (id `5622d54d-7f0c-4d57-83f0-0bc1899d8bc8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 175 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def ready(self): post_migrate.connect(create_default_site, sender=self) checks.register(check_site_id, checks.Tags.sites) [2d76a1c9]
- class SitesConfig(AppConfig): default_auto_field = "django.db.models.AutoField" name = "django.contrib.sites" verbose_name = _("Sites") [1b6692e4]
- from .management import create_default_site [61036001]
- from django.apps import AppConfig from django.contrib.sites.checks import check_site_id from django.core import checks from django.db.models.signals import post_migrate from django.utils.translation import gettext_lazy as _ [f86f0fd2]

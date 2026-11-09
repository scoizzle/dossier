# django/contrib/admin/apps

- Subject: django/contrib/admin/apps (id `5cfb8685-245c-4b2d-adfd-2c4a05bf6188`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 266 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- def ready(self): checks.register(check_dependencies, checks.Tags.admin) checks.register(check_admin_app, checks.Tags.admin) [da65a654]
- def ready(self): super().ready() self.module.autodiscover() [bf329459]
- default = True [a6891085]
- default_auto_field = "django.db.models.AutoField" default_site = "django.contrib.admin.sites.AdminSite" name = "django.contrib.admin" verbose_name = _("Administration") [b4a7bf8f]
- class AdminConfig(SimpleAdminConfig): """The default AppConfig for admin which does autodiscovery.""" [2369fa9f]
- class SimpleAdminConfig(AppConfig): """Simple AppConfig which does not do automatic discovery.""" [6165a777]
- from django.apps import AppConfig from django.contrib.admin.checks import check_admin_app, check_dependencies from django.core import checks from django.utils.translation import gettext_lazy as _ [50b44ce3]

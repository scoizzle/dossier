# django/contrib/admin/apps

- Subject: django/contrib/admin/apps (id `1a7f4b79-d483-44a6-90b9-895fe8b91237`)
- Kind: subject
- Budget: 1200 tokens
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

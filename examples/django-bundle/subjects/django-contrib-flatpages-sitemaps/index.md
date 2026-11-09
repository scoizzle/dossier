# django/contrib/flatpages/sitemaps

- Subject: django/contrib/flatpages/sitemaps (id `b01d4806-6f09-47ed-ad13-c176f32f8124`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 148 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- class FlatPageSitemap(Sitemap): def items(self): if not django_apps.is_installed("django.contrib.sites"): raise ImproperlyConfigured( "FlatPageSitemap requires django.contrib.sites, which isn't installed." ) Site = django_apps.get_model("sites.Site") current_site = Site.objects.get_current() return current_site.flatpage_set.filter(registration_required=False) [bd5e1602]
- from django.apps import apps as django_apps from django.contrib.sitemaps import Sitemap from django.core.exceptions import ImproperlyConfigured [b8334d8e]

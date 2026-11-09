# django/contrib/flatpages/sitemaps

- Subject: django/contrib/flatpages/sitemaps (id `b6a0cc7c-d07f-432d-bc08-42638932284c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 148 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- class FlatPageSitemap(Sitemap): def items(self): if not django_apps.is_installed("django.contrib.sites"): raise ImproperlyConfigured( "FlatPageSitemap requires django.contrib.sites, which isn't installed." ) Site = django_apps.get_model("sites.Site") current_site = Site.objects.get_current() return current_site.flatpage_set.filter(registration_required=False) [bd5e1602]
- from django.apps import apps as django_apps from django.contrib.sitemaps import Sitemap from django.core.exceptions import ImproperlyConfigured [b8334d8e]

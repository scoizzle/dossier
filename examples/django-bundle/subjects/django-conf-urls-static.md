# django/conf/urls/static

- Subject: django/conf/urls/static (id `239c802d-451c-4d5f-a6c0-767c839a7307`)
- Kind: subject
- Budget: 1200 tokens
- Used: 254 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- from django.conf import settings from django.conf.urls.static import static [dcdde08e]
- urlpatterns = [ # ... the rest of your URLconf goes here ... ] + static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT) """ if not prefix: raise ImproperlyConfigured("Empty static prefix not permitted") elif not settings.DEBUG or urlsplit(prefix).netloc: # No-op if not in debug mode or a non-local prefix. return [] return [ re_path( r"^%s(?P<path>.*)$" % re.escape(prefix.lstrip("/")), view, kwargs=kwargs ), ] [fa4257ce]
- def static(prefix, view=serve, **kwargs): """ Return a URL pattern for serving files in debug mode. [bad383d9]
- from django.conf import settings from django.core.exceptions import ImproperlyConfigured from django.urls import re_path from django.views.static import serve [00065c35]
- import re from urllib.parse import urlsplit [0b6ef158a9986b9e]

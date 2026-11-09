# django/contrib/staticfiles/urls

- Subject: django/contrib/staticfiles/urls (id `5cccba53-171e-48e4-8fcf-d5f940d2982c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 157 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- # Only append if urlpatterns are empty if settings.DEBUG and not urlpatterns: urlpatterns += staticfiles_urlpatterns() [4eab12b2]
- def staticfiles_urlpatterns(prefix=None): """ Helper function to return a URL pattern for serving static files. """ if prefix is None: prefix = settings.STATIC_URL return static(prefix, view=serve) [d8b7672b]
- from django.conf import settings from django.conf.urls.static import static from django.contrib.staticfiles.views import serve [8ffea767]
- urlpatterns = [] [2e718ebd]

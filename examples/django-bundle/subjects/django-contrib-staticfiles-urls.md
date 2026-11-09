# django/contrib/staticfiles/urls

- Subject: django/contrib/staticfiles/urls (id `4fc5a6ae-2913-4883-b04a-abee1879b938`)
- Kind: subject
- Budget: 1200 tokens
- Used: 157 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- # Only append if urlpatterns are empty if settings.DEBUG and not urlpatterns: urlpatterns += staticfiles_urlpatterns() [4eab12b2]
- def staticfiles_urlpatterns(prefix=None): """ Helper function to return a URL pattern for serving static files. """ if prefix is None: prefix = settings.STATIC_URL return static(prefix, view=serve) [d8b7672b]
- from django.conf import settings from django.conf.urls.static import static from django.contrib.staticfiles.views import serve [8ffea767]
- urlpatterns = [] [2e718ebd]

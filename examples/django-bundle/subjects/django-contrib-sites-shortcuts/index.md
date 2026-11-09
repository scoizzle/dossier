# django/contrib/sites/shortcuts

- Subject: django/contrib/sites/shortcuts (id `18590435-fc41-4ae3-a10e-3371a98ce4ae`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 170 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- return Site.objects.get_current(request) else: return RequestSite(request) [458d791a]
- def get_current_site(request): """ Check if contrib.sites is installed and return either the current ``Site`` object or a ``RequestSite`` object based on the request. """ # Import is inside the function because its point is to avoid importing the # Site models when django.contrib.sites isn't installed. if apps.is_installed("django.contrib.sites"): from .models import Site [39566c30]
- from .requests import RequestSite [c803bfd6]
- from django.apps import apps [ef9e7b09]

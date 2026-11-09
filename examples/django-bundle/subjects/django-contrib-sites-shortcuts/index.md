# django/contrib/sites/shortcuts

- Subject: django/contrib/sites/shortcuts (id `c022add4-2f1d-4ff0-b63a-7f239a64f70a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 170 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- return Site.objects.get_current(request) else: return RequestSite(request) [458d791a]
- def get_current_site(request): """ Check if contrib.sites is installed and return either the current ``Site`` object or a ``RequestSite`` object based on the request. """ # Import is inside the function because its point is to avoid importing the # Site models when django.contrib.sites isn't installed. if apps.is_installed("django.contrib.sites"): from .models import Site [39566c30]
- from .requests import RequestSite [c803bfd6]
- from django.apps import apps [ef9e7b09]

# django/contrib/sites/middleware

- Subject: django/contrib/sites/middleware (id `b5b4d028-738d-4597-9b16-f7aa70eea147`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 113 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def process_request(self, request): request.site = get_current_site(request) [5f63a503]
- class CurrentSiteMiddleware(MiddlewareMixin): """ Middleware that sets `site` attribute to request object. """ [999032fd]
- from .shortcuts import get_current_site [bf78c971]
- from django.utils.deprecation import MiddlewareMixin [2beffa4a]

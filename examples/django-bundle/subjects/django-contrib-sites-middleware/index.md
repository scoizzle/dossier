# django/contrib/sites/middleware

- Subject: django/contrib/sites/middleware (id `dc2c480b-77c1-4858-b100-49054ae9b2ed`)
- Kind: subject
- Budget: 1200 tokens
- Used: 113 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def process_request(self, request): request.site = get_current_site(request) [5f63a503]
- class CurrentSiteMiddleware(MiddlewareMixin): """ Middleware that sets `site` attribute to request object. """ [999032fd]
- from .shortcuts import get_current_site [bf78c971]
- from django.utils.deprecation import MiddlewareMixin [2beffa4a]

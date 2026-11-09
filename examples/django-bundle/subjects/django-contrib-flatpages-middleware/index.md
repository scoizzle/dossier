# django/contrib/flatpages/middleware

- Subject: django/contrib/flatpages/middleware (id `5f3362f1-9c9a-482a-b195-0e683604a889`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 184 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- class FlatpageFallbackMiddleware(MiddlewareMixin): def process_response(self, request, response): if response.status_code != 404: return response # No need to check for a flatpage for non-404 responses. try: return flatpage(request, request.path_info) # Return the original response if any errors happened. Because this # is a middleware, we can't assume the errors will be caught elsewhere. except Http404: return response except Exception: if settings.DEBUG: raise return response [e600bcc4]
- from django.conf import settings from django.contrib.flatpages.views import flatpage from django.http import Http404 from django.utils.deprecation import MiddlewareMixin [9bff75f2]

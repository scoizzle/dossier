# django/contrib/redirects/middleware

- Subject: django/contrib/redirects/middleware (id `0b82c15e-6595-4f0d-8d0b-a74f4478fee9`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 462 tokens
- Facts shown: 7 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # No redirect was found. Return the response. return response [52978b1d]
- full_path = request.get_full_path() current_site = get_current_site(request) [7f1ced77]
- r = None try: r = Redirect.objects.get(site=current_site, old_path=full_path) except Redirect.DoesNotExist: pass if r is None and settings.APPEND_SLASH and not request.path.endswith("/"): try: r = Redirect.objects.get( site=current_site, old_path=request.get_full_path(force_append_slash=True), ) except Redirect.DoesNotExist: pass if r is not None: if r.new_path == "": return self.response_gone_class() return self.response_redirect_class(r.new_path) [9aa2fbc0]
- def __init__(self, get_response): if not apps.is_installed("django.contrib.sites"): raise ImproperlyConfigured( "You cannot use RedirectFallbackMiddleware when " "django.contrib.sites is not installed." ) super().__init__(get_response) [ff9fb72d]
- def process_response(self, request, response): # No need to check for a redirect for non-404 responses. if response.status_code != 404: return response [0085336b]
- class RedirectFallbackMiddleware(MiddlewareMixin): # Defined as class-level attributes to be subclassing-friendly. response_gone_class = HttpResponseGone response_redirect_class = HttpResponsePermanentRedirect [43bd3660]
- from django.apps import apps from django.conf import settings from django.contrib.redirects.models import Redirect from django.contrib.sites.shortcuts import get_current_site from django.core.exceptions import ImproperlyConfigured from django.http import HttpResponseGone, HttpResponsePermanentRedirect from django.utils.deprecation import MiddlewareMixin [1eee4299]

# django/template/context_processors

- Subject: django/template/context_processors (id `5b8dcc44-ab44-4a76-ad29-0dcfa2b3c0e5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 761 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- # Return a lazy reference that computes connection.queries on access, # to ensure it contains queries triggered after this function runs. context_extras["sql_queries"] = lazy( lambda: list( itertools.chain.from_iterable( connections[x].queries for x in connections ) ), list, ) return context_extras [bf2581f3]
- def _get_val(): token = get_token(request) if token is None: # In order to be able to provide debugging info in the # case of misconfiguration, we use a sentinel value # instead of returning an empty dict. return "NOTPROVIDED" else: return token [725d1de8]
- return { "LANGUAGES": settings.LANGUAGES, "LANGUAGE_CODE": translation.get_language(), "LANGUAGE_BIDI": translation.get_language_bidi(), } [109ce8c9]
- return {"TIME_ZONE": timezone.get_current_timezone_name()} [95470fe2]
- return {"csrf_token": SimpleLazyObject(_get_val)} [db68ca1c]
- """ A set of request processors that return dictionaries to be merged into a template context. Each function takes the request object as its only parameter and returns a dictionary to add to the context. [a154aaca]
- These are referenced from the 'context_processors' option of the configuration of a DjangoTemplates backend and used by RequestContext. """ [73bd0b8a]
- def csp(request): """ Add the CSP nonce to the context. """ return {CSP_CONTEXT_KEY: get_nonce(request)} [dbdc20b1]
- def csrf(request): """ Context processor that provides a CSRF token, or the string 'NOTPROVIDED' if it has not been provided by either a view decorator or the middleware """ [4e17d0ee]
- def debug(request): """ Return context variables helpful for debugging. """ context_extras = {} if settings.DEBUG and request.META.get("REMOTE_ADDR") in settings.INTERNAL_IPS: context_extras["debug"] = True from django.db import connections [cc115f09]
- def i18n(request): from django.utils import translation [4c2bbc8b]
- def media(request): """ Add media-related context variables to the context. """ return {"MEDIA_URL": settings.MEDIA_URL} [a206a960]
- def request(request): return {"request": request} [fd28e598]
- def static(request): """ Add static-related context variables to the context. """ return {"STATIC_URL": settings.STATIC_URL} [2942dfe1]
- def tz(request): from django.utils import timezone [634a31cb]
- from django.conf import settings from django.middleware.csp import get_nonce from django.middleware.csrf import get_token from django.utils.csp import CONTEXT_KEY as CSP_CONTEXT_KEY from django.utils.functional import SimpleLazyObject, lazy [1e69f9a8]
- import itertools [cc75e9f77a7bfb06-2]

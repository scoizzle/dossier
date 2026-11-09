# django/middleware/cache

- Subject: django/middleware/cache (id `499d156d-3024-4f0e-9dd4-bb167e15b6cc`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2421 tokens
- Facts shown: 39 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Derive the age estimation of the cached response. if (max_age_seconds := get_max_age(response)) is not None and ( expires_timestamp := parse_http_date_safe(response["Expires"]) ) is not None: now_timestamp = int(time.time()) remaining_seconds = expires_timestamp - now_timestamp # Use Age: 0 if local clock got turned back. response["Age"] = max(0, max_age_seconds - remaining_seconds) [d1e4df3e]
- # Don't cache responses that set a user-specific (and maybe security # sensitive) cookie while varying on Cookie. if response.cookies and has_vary_header(response, "Cookie"): return response [c4c415a4]
- # Don't cache responses when the Cache-Control header is set to # private, no-cache, or no-store. Qualified forms like # `private="Set-Cookie"` reduce to their directive name and match too. cache_control_parts = set( split_directive_names(response.get("Cache-Control", "")) ) if cache_control_parts.intersection({"private", "no-cache", "no-store"}): return response [dc1563b3]
- # Don't cache responses when the Vary header contains '*'. if has_vary_header(response, "*"): return response [a3f2cb0f]
- # Page timeout takes precedence over the "max-age" and the default # cache timeout. timeout = self.page_timeout if timeout is None: # The timeout from the "max-age" section of the "Cache-Control" # header takes precedence over the default cache timeout. timeout = get_max_age(response) if timeout is None: timeout = self.cache_timeout elif timeout == 0: # max-age was set to 0, don't cache. return response patch_response_headers(response, timeout) # Make the response vary on Authorization if the request bears that # header, unless allowed by "public" per RFC 9111, Section 3.5. No # exceptions are made for "s-maxage" and "must-revalidate" since these # are not currently implemented by Django. if request.headers.get("Authorization") and "public" not in cache_control_parts: patch_vary_headers(response, ("Authorization",)) if timeout and response.status_code == 200: cache_key = learn_cache_key( request, response, timeout, self.key_prefix, cache=self.cache ) if hasattr(response, "render") and callable(response.render): response.add_post_render_callback( lambda r: self.cache.set(cache_key, r, timeout) ) else: self.cache.set(cache_key, response, timeout) return response [1f9e5f1d]
- # hit, return cached response request._cache_update_cache = False return response [895fe453]
- # try and get the cached GET response cache_key = get_cache_key(request, self.key_prefix, "GET", cache=self.cache) if cache_key is None: request._cache_update_cache = True return None # No cache information available, need to rebuild. response = self.cache.get(cache_key) # if it wasn't found and we are looking for a HEAD, try looking just # for that if response is None and request.method == "HEAD": cache_key = get_cache_key( request, self.key_prefix, "HEAD", cache=self.cache ) response = self.cache.get(cache_key) [585d4a21]
- if cache_timeout is not None: self.cache_timeout = cache_timeout self.page_timeout = page_timeout [592e3c3d]
- if response is None: request._cache_update_cache = True return None # No cache information available, need to rebuild. [7248c55a]
- if response.streaming or response.status_code not in (200, 304): return response [38de4b9b]

## All facts

- [75d4a9bb] try: key_prefix = kwargs["key_prefix"] if key_prefix is None: key_prefix = "" self.key_prefix = key_prefix except KeyError: pass try: cache_alias = kwargs["cache_alias"] if cache_alias is None: cache_alias = DEFAULT_CACHE_ALIAS self.cache_alias = cache_alias except KeyError: pass
- [0b2463de0782a8a0] @property def cache(self): return caches[self.cache_alias]
- [0b2463de0782a8a0-2] @property def cache(self): return caches[self.cache_alias]
- [33fbc2bb] Also used as the hook point for the cache decorator, which is generated using the decorator-from-middleware utility. """
- [bbe3b265] MIDDLEWARE = [ 'django.middleware.cache.UpdateCacheMiddleware', ... 'django.middleware.cache.FetchFromCacheMiddleware' ]
- [4e91819d] Must be used as part of the two-part update/fetch cache middleware. FetchFromCacheMiddleware must be the last piece of middleware in MIDDLEWARE so that it'll get called last during the request phase. """
- [761a6eac] Must be used as part of the two-part update/fetch cache middleware. UpdateCacheMiddleware must be the first piece of middleware in MIDDLEWARE so that it'll get called last during the response phase. """
- [da1f6267] def __init__(self, get_response): super().__init__(get_response) self.cache_timeout = settings.CACHE_MIDDLEWARE_SECONDS self.page_timeout = None self.key_prefix = settings.CACHE_MIDDLEWARE_KEY_PREFIX self.cache_alias = settings.CACHE_MIDDLEWARE_ALIAS
- [982e6b6a] def __init__(self, get_response): super().__init__(get_response) self.key_prefix = settings.CACHE_MIDDLEWARE_KEY_PREFIX self.cache_alias = settings.CACHE_MIDDLEWARE_ALIAS
- [796d6a26] def __init__(self, get_response, cache_timeout=None, page_timeout=None, **kwargs): super().__init__(get_response) # We need to differentiate between "provided, but using default value", # and "not provided". If the value is provided using a default, then # we fall back to system defaults. If it is not provided at all, # we need to use middleware defaults.
- [119486fc] def _should_update_cache(self, request, response): return hasattr(request, "_cache_update_cache") and request._cache_update_cache
- [d87313b5] def process_request(self, request): """ Check whether the page is already cached and return the cached version if available. """ if request.method not in ("GET", "HEAD"): request._cache_update_cache = False return None # Don't bother checking the cache.
- [e4ca573f] def process_response(self, request, response): """Set the cache, if needed.""" if not self._should_update_cache(request, response): # We don't need to update the cache, just return. return response
- [92964e45] """ Cache middleware. If enabled, each Django-powered page will be cached based on URL. The canonical way to enable cache middleware is to set ``UpdateCacheMiddleware`` as your first piece of middleware, and ``FetchFromCacheMiddleware`` as the last::
- [b7770531] * If the request had an Authorization header and the response was not marked "Cache-Control: public", the response will vary on Authorization. """
- [b73e0e01] * Only GET or HEAD-requests with status code 200 are cached.
- [daecc6da] * Pages will be cached based on the contents of the request headers listed in the response's "Vary" header.
- [d84dc992] * The number of seconds each page is stored for is set by the "max-age" section of the response's "Cache-Control" header, falling back to the CACHE_MIDDLEWARE_SECONDS setting if the section was not found.
- [b60d598b] * This middleware also sets ETag, Last-Modified, Expires and Cache-Control headers on the response object.
- [47a9ed19] * This middleware expects that a HEAD request is answered with the same response headers exactly like the corresponding GET request.
- [a27d651b] * When a hit occurs, a shallow copy of the original response object is returned from process_request.
- [1d0145cf] More details about how the caching works:
- [b7781190] The single-class ``CacheMiddleware`` can be used for some simple sites. However, if any other piece of middleware needs to affect the cache key, you'll need to use the two-part ``UpdateCacheMiddleware`` and ``FetchFromCacheMiddleware``. This'll most often happen when you're using Django's ``LocaleMiddleware``.
- [576b175c] This is counterintuitive, but correct: ``UpdateCacheMiddleware`` needs to run last during the response phase, which processes middleware bottom-up; ``FetchFromCacheMiddleware`` needs to run last during the request phase, which processes middleware top-down.
- [34db66b5] class CacheMiddleware(UpdateCacheMiddleware, FetchFromCacheMiddleware): """ Cache middleware that provides basic behavior for many simple sites.
- [efe39b8a] class FetchFromCacheMiddleware(MiddlewareMixin): """ Request-phase cache middleware that fetches a page from the cache.
- [11282d3f] class UpdateCacheMiddleware(MiddlewareMixin): """ Response-phase cache middleware that updates the cache if the response is cacheable.
- [6c0f9ada] from django.conf import settings from django.core.cache import DEFAULT_CACHE_ALIAS, caches from django.utils.cache import ( get_cache_key, get_max_age, has_vary_header, learn_cache_key, patch_response_headers, patch_vary_headers, ) from django.utils.deprecation import MiddlewareMixin from django.utils.http import parse_http_date_safe, split_directive_names
- [4e1c949b] import time

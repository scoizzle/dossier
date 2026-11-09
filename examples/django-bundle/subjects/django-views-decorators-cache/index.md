# django/views/decorators/cache

- Subject: django/views/decorators/cache (id `3b16cf45-e4f7-4bd8-90bd-38b3cfbc8ba6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 780 tokens
- Facts shown: 18 facts
- Conflicts: 0
- Gaps: 0

## Facts

- async def _view_wrapper(request, *args, **kw): _check_request(request, "cache_control") response = await viewfunc(request, *args, **kw) patch_cache_control(response, **kwargs) return response [c7981e5e]
- def _view_wrapper(request, *args, **kw): _check_request(request, "cache_control") response = viewfunc(request, *args, **kw) patch_cache_control(response, **kwargs) return response [b0dec1f9]
- async def _view_wrapper(request, *args, **kwargs): _check_request(request, "never_cache") response = await view_func(request, *args, **kwargs) add_never_cache_headers(response) return response [2234264e]
- def _view_wrapper(request, *args, **kwargs): _check_request(request, "never_cache") response = view_func(request, *args, **kwargs) add_never_cache_headers(response) return response [974ebc16]
- else: [6ad07797f4838346-17]
- return wraps(viewfunc)(_view_wrapper) [a909dd44]
- Additionally, all headers from the response's Vary header will be taken into account on caching -- just like the middleware does. """ return decorator_from_middleware_with_args(CacheMiddleware)( page_timeout=timeout, cache_alias=cache, key_prefix=key_prefix, ) [f23b761a]
- The cache is keyed by the URL and some data from the headers. Additionally there is the key prefix that is used to distinguish different cache areas in a multi-site setup. You could use the get_current_site().domain, for example, as that is unique across a Django project. [f9ef1512]
- else: [6ad07797f4838346-18]
- if iscoroutinefunction(view_func): [010008b1ac80cb06-3]
- return _cache_controller [3b3fbf72]
- return wraps(view_func)(_view_wrapper) [87be1c7b56ac3a0b-3]
- def _check_request(request, decorator_name): # Ensure argument looks like a request. if not hasattr(request, "META"): raise TypeError( f"{decorator_name} didn't receive an HttpRequest. If you are " "decorating a classmethod, be sure to use @method_decorator." ) [4a9c91a4]
- def cache_control(**kwargs): def _cache_controller(viewfunc): if iscoroutinefunction(viewfunc): [d085a0db]
- def cache_page(timeout, *, cache=None, key_prefix=None): """ Decorator for views that tries getting the page from the cache and populates the cache if the page isn't in the cache yet. [0929dba1]
- def never_cache(view_func): """ Decorator that adds headers to a response so that it will never be cached. """ [2bd57001]
- from django.middleware.cache import CacheMiddleware from django.utils.cache import add_never_cache_headers, patch_cache_control from django.utils.decorators import decorator_from_middleware_with_args [6dbe0d62]
- from functools import wraps from inspect import iscoroutinefunction [7391182f29420620]

# django/views/decorators/http

- Subject: django/views/decorators/http (id `65b4678c-1f99-4251-bae2-8bc5b0ea53e6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1599 tokens
- Facts shown: 30 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- @wraps(func) async def inner(request, *args, **kwargs): if request.method not in request_method_list: response = HttpResponseNotAllowed(request_method_list) log_response( "Method Not Allowed (%s): %s", request.method, request.path, response=response, request=request, ) return response return await func(request, *args, **kwargs) [76753044]
- @wraps(func) async def inner(request, *args, **kwargs): response, res_etag, res_last_modified = _pre_process_request( request, *args, **kwargs ) if response is None: response = await func(request, *args, **kwargs) _post_process_request(request, response, res_etag, res_last_modified) return response [64ed0dc6]
- @wraps(func) def inner(request, *args, **kwargs): if request.method not in request_method_list: response = HttpResponseNotAllowed(request_method_list) log_response( "Method Not Allowed (%s): %s", request.method, request.path, response=response, request=request, ) return response return func(request, *args, **kwargs) [7e1d6981]
- @wraps(func) def inner(request, *args, **kwargs): response, res_etag, res_last_modified = _pre_process_request( request, *args, **kwargs ) if response is None: response = func(request, *args, **kwargs) _post_process_request(request, response, res_etag, res_last_modified) return response [861c2b27]
- @require_http_methods(["GET", "POST"]) def my_view(request): # I can assume now that only GET or POST requests make it this far # ... [dfb28e7b]
- def _post_process_request(request, response, res_etag, res_last_modified): # Set relevant headers on the response if they don't already exist # and if the request method is safe. if request.method in ("GET", "HEAD"): if res_last_modified and not response.has_header("Last-Modified"): response.headers["Last-Modified"] = http_date(res_last_modified) if res_etag: response.headers.setdefault("ETag", res_etag) [b88e782d]
- else: [6ad07797f4838346-26]
- else: [6ad07797f4838346-27]
- if iscoroutinefunction(func): [9b3c6cee9ff9a8ff-2]
- return inner [b9689d746b8236ce-6]
- return inner [b9689d746b8236ce-7]
- Note that request methods should be in uppercase. """ [090e7cbe]
- The ETag function should return a complete ETag, including quotes (e.g. '"etag"'), since that's the only way to distinguish between weak and strong ETags. If an unquoted ETag is returned (e.g. 'etag'), it will be converted to a strong ETag by adding quotes. [1ec170be]
- The parameters are callables to compute the ETag and last modified time for the requested resource, respectively. The callables are passed the same parameters as the view itself. The ETag function should return a string (or None if the resource doesn't exist), while the last_modified function should return a datetime object (or None if the resource doesn't exist). [cfeca162]
- This decorator will either pass control to the wrapped view function or return an HTTP 304 response (unmodified) or 412 response (precondition failed), depending upon the request method. In either case, the decorator will add the generated ETag and Last-Modified headers to the response if the headers aren't already set and if the request's method is safe. """ [d7395ce4]
- return decorator [021b5df2d691cbd2-10]

## All facts

- [294c2a35] def decorator(func): def _pre_process_request(request, *args, **kwargs): # Compute values (if any) for the requested resource. res_last_modified = None if last_modified_func: if dt := last_modified_func(request, *args, **kwargs): if not timezone.is_aware(dt): dt = timezone.make_aware(dt, datetime.UTC) res_last_modified = int(dt.timestamp()) # The value from etag_func() could be quoted or unquoted. res_etag = etag_func(request, *args, **kwargs) if etag_func else None res_etag = quote_etag(res_etag) if res_etag is not None else None response = get_conditional_response( request, etag=res_etag, last_modified=res_last_modified, ) return response, res_etag, res_last_modified
- [b9afc59d556f7366] def decorator(func): if iscoroutinefunction(func):
- [021b5df2d691cbd2-11] return decorator
- [dc03318e] """ Decorators for views based on HTTP headers. """
- [da646f98] # Shortcut decorators for common cases based on ETag or Last-Modified only def etag(etag_func): return condition(etag_func=etag_func)
- [c151a1e0] conditional_page = decorator_from_middleware(ConditionalGetMiddleware)
- [430379cf] def condition(etag_func=None, last_modified_func=None): """ Decorator to support conditional retrieval (or change) for a view function.
- [0ed1ec6e] def last_modified(last_modified_func): return condition(last_modified_func=last_modified_func)
- [47f95029] def require_http_methods(request_method_list): """ Decorator to make a view only accept particular request methods. Usage::
- [0b764db1] from django.http import HttpResponseNotAllowed from django.middleware.http import ConditionalGetMiddleware from django.utils import timezone from django.utils.cache import get_conditional_response from django.utils.decorators import decorator_from_middleware from django.utils.http import http_date, quote_etag from django.utils.log import log_response
- [6ec31215] import datetime from functools import wraps from inspect import iscoroutinefunction
- [736b18ee] require_GET = require_http_methods(["GET"]) require_GET.__doc__ = "Decorator to require that a view only accepts the GET method."
- [3a94a036] require_POST = require_http_methods(["POST"]) require_POST.__doc__ = "Decorator to require that a view only accepts the POST method."
- [ac05727b] require_safe = require_http_methods(["GET", "HEAD"]) require_safe.__doc__ = ( "Decorator to require that a view only accepts safe methods: GET and HEAD." )

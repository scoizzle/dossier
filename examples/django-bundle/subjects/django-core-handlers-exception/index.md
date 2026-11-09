# django/core/handlers/exception

- Subject: django/core/handlers/exception (id `8eca0e63-7668-4a9f-b01f-ccd8c036be1e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1411 tokens
- Facts shown: 23 of 23
- Conflicts: 0
- Gaps: 0

## Highlights

- @wraps(get_response) async def inner(request): try: response = await get_response(request) except Exception as exc: response = await sync_to_async( response_for_exception, thread_sensitive=False )(request, exc) return response [2da6c6df]
- @wraps(get_response) def inner(request): try: response = get_response(request) except Exception as exc: response = response_for_exception(request, exc) return response [c72f5b4e]
- if settings.DEBUG: response = debug.technical_500_response( request, *sys.exc_info(), status_code=400 ) else: response = get_exception_response( request, get_resolver(get_urlconf()), 400, exc ) # The logger is set to django.security, which specifically captures # SuspiciousOperation events, unlike the default django.request logger. security_logger = logging.getLogger(f"django.security.{exc.__class__.__name__}") log_response( str(exc), exception=exc, request=request, response=response, level="error", logger=security_logger, ) [415fcd41]
- return inner [b9689d746b8236ce-2]
- return inner else: [c1ca5b97]
- # Force a TemplateResponse to be rendered. if not getattr(response, "is_rendered", True) and callable( getattr(response, "render", None) ): response = response.render() [0ac4f1e6]
- # Return an HttpResponse that displays a friendly error message. callback = resolver.resolve_error_handler(500) return callback(request) [e214acab]
- All exceptions will be converted. All known 4xx exceptions (Http404, PermissionDenied, MultiPartParserError, SuspiciousOperation) will be converted to the appropriate response, and all other exceptions will be converted to 500 responses. [fcfa29a3]
- This decorator is automatically applied to all middleware to ensure that no middleware leaks an exception and that the next middleware in the stack can rely on getting a response instead of an exception. """ if iscoroutinefunction(get_response): [ac7dea89]
- elif isinstance(exc, BadRequest): if settings.DEBUG: response = debug.technical_500_response( request, *sys.exc_info(), status_code=400 ) else: response = get_exception_response( request, get_resolver(get_urlconf()), 400, exc ) log_response( "%s: %s", str(exc), request.path, response=response, request=request, exception=exc, ) elif isinstance(exc, SuspiciousOperation): if isinstance(exc, (RequestDataTooBig, TooManyFieldsSent, TooManyFilesSent)): # POST data can't be accessed again, otherwise the original # exception would be raised. request._mark_post_parse_error() [c49b72f1]
- elif isinstance(exc, MultiPartParserError): response = get_exception_response( request, get_resolver(get_urlconf()), 400, exc ) log_response( "Bad request (Unable to parse request body): %s", request.path, response=response, request=request, exception=exc, ) [f0238765]
- elif isinstance(exc, PermissionDenied): response = get_exception_response( request, get_resolver(get_urlconf()), 403, exc ) log_response( "Forbidden (Permission denied): %s", request.path, response=response, request=request, exception=exc, ) [6374d46d]
- if settings.DEBUG: return debug.technical_500_response(request, *exc_info) [5cbf4406]
- return response [8034aacd88b9c7ae-2]
- return response [8034aacd88b9c7ae-3]

## All facts

- [46d5580f] else: signals.got_request_exception.send(sender=None, request=request) response = handle_uncaught_exception( request, get_resolver(get_urlconf()), sys.exc_info() ) log_response( "%s: %s", response.reason_phrase, request.path, response=response, request=request, exception=exc, )
- [3be4901f] def convert_exception_to_response(get_response): """ Wrap the given get_response callable in exception-to-response conversion.
- [4e4f687c] def get_exception_response(request, resolver, status_code, exception): try: callback = resolver.resolve_error_handler(status_code) response = callback(request, exception=exception) except Exception: signals.got_request_exception.send(sender=None, request=request) response = handle_uncaught_exception(request, resolver, sys.exc_info())
- [8eccd44d] def handle_uncaught_exception(request, resolver, exc_info): """ Processing for any otherwise uncaught exceptions (those that will generate HTTP 500 responses). """ if settings.DEBUG_PROPAGATE_EXCEPTIONS: raise
- [c41c95a1] def response_for_exception(request, exc): if isinstance(exc, Http404): if settings.DEBUG: response = debug.technical_404_response(request, exc) else: response = get_exception_response( request, get_resolver(get_urlconf()), 404, exc )
- [770890ad88958a4c-9] from asgiref.sync import sync_to_async
- [763b9a56] from django.conf import settings from django.core import signals from django.core.exceptions import ( BadRequest, PermissionDenied, RequestDataTooBig, SuspiciousOperation, TooManyFieldsSent, TooManyFilesSent, ) from django.http import Http404 from django.http.multipartparser import MultiPartParserError from django.urls import get_resolver, get_urlconf from django.utils.log import log_response from django.views import debug
- [6289e363] import logging import sys from functools import wraps from inspect import iscoroutinefunction

# django/core/handlers/exception

- Subject: django/core/handlers/exception (id `6cf5fcd3-43be-479d-a8af-d86faee01588`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 15 of 23
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

8 more facts did not fit in the budget: [46d5580f] [3be4901f] [4e4f687c] [8eccd44d] [c41c95a1] [770890ad88958a4c-9] [763b9a56] [6289e363]

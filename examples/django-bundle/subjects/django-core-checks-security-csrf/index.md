# django/core/checks/security/csrf

- Subject: django/core/checks/security/csrf (id `841e40b3-c2e9-44a1-82ae-4a5fedb15edc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 538 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- errors = [] try: view = _get_failure_view() except ImportError: msg = ( "The CSRF failure view '%s' could not be imported." % settings.CSRF_FAILURE_VIEW ) errors.append(Error(msg, id="security.E102")) else: try: signature(view).bind(None, reason=None) except TypeError: msg = ( "The CSRF failure view '%s' does not take the correct number of " "arguments." % settings.CSRF_FAILURE_VIEW ) errors.append(Error(msg, id="security.E101")) return errors [39f9f316]
- @register(Tags.security) def check_csrf_failure_view(app_configs, **kwargs): from django.middleware.csrf import _get_failure_view [d95d041c]
- @register(Tags.security, deploy=True) def check_csrf_cookie_secure(app_configs, **kwargs): passed_check = ( settings.CSRF_USE_SESSIONS or not _csrf_middleware() or settings.CSRF_COOKIE_SECURE is True ) return [] if passed_check else [W016] [13a4639c]
- @register(Tags.security, deploy=True) def check_csrf_middleware(app_configs, **kwargs): passed_check = _csrf_middleware() return [] if passed_check else [W003] [c7c42987]
- W003 = Warning( "You don't appear to be using Django's built-in " "cross-site request forgery protection via the middleware " "('django.middleware.csrf.CsrfViewMiddleware' is not in your " "MIDDLEWARE). Enabling the middleware is the safest approach " "to ensure you don't leave any holes.", id="security.W003", ) [5242e86c]
- W016 = Warning( "You have 'django.middleware.csrf.CsrfViewMiddleware' in your " "MIDDLEWARE, but you have not set CSRF_COOKIE_SECURE to True. " "Using a secure-only CSRF cookie makes it more difficult for network " "traffic sniffers to steal the CSRF token.", id="security.W016", ) [0fe968d3]
- def _csrf_middleware(): return "django.middleware.csrf.CsrfViewMiddleware" in settings.MIDDLEWARE [b6062b18]
- from django.conf import settings from django.core.checks import Error, Tags, Warning, register from django.utils.inspect import signature [e2219897]

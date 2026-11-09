# django/core/checks/security/sessions

- Subject: django/core/checks/security/sessions (id `69029766-af60-441d-9305-05037ef3f759`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 698 tokens
- Facts shown: 13 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @register(Tags.security, deploy=True) def check_session_cookie_httponly(app_configs, **kwargs): if settings.SESSION_COOKIE_HTTPONLY is True: return [] errors = [] if _session_app(): errors.append(W013) if _session_middleware(): errors.append(W014) if len(errors) > 1: errors = [W015] return errors [e2804f64]
- @register(Tags.security, deploy=True) def check_session_cookie_secure(app_configs, **kwargs): if settings.SESSION_COOKIE_SECURE is True: return [] errors = [] if _session_app(): errors.append(W010) if _session_middleware(): errors.append(W011) if len(errors) > 1: errors = [W012] return errors [ab7d7af8]
- W010 = Warning( add_session_cookie_message( "You have 'django.contrib.sessions' in your INSTALLED_APPS, " "but you have not set SESSION_COOKIE_SECURE to True." ), id="security.W010", ) [84c168e0]
- W011 = Warning( add_session_cookie_message( "You have 'django.contrib.sessions.middleware.SessionMiddleware' " "in your MIDDLEWARE, but you have not set " "SESSION_COOKIE_SECURE to True." ), id="security.W011", ) [4d25800f]
- W012 = Warning( add_session_cookie_message("SESSION_COOKIE_SECURE is not set to True."), id="security.W012", ) [aeca2448]
- W013 = Warning( add_httponly_message( "You have 'django.contrib.sessions' in your INSTALLED_APPS, " "but you have not set SESSION_COOKIE_HTTPONLY to True.", ), id="security.W013", ) [15ae9d0f]
- W014 = Warning( add_httponly_message( "You have 'django.contrib.sessions.middleware.SessionMiddleware' " "in your MIDDLEWARE, but you have not set " "SESSION_COOKIE_HTTPONLY to True." ), id="security.W014", ) [7cce4172]
- W015 = Warning( add_httponly_message("SESSION_COOKIE_HTTPONLY is not set to True."), id="security.W015", ) [7cbbc686]
- def _session_app(): return "django.contrib.sessions" in settings.INSTALLED_APPS [669994b2]
- def _session_middleware(): return "django.contrib.sessions.middleware.SessionMiddleware" in settings.MIDDLEWARE [147d20f6]
- def add_httponly_message(message): return message + ( " Using an HttpOnly session cookie makes it more difficult for " "cross-site scripting attacks to hijack user sessions." ) [90f6cef0]
- def add_session_cookie_message(message): return message + ( " Using a secure-only session cookie makes it more difficult for " "network traffic sniffers to hijack user sessions." ) [8456ee54]
- from django.conf import settings from django.core.checks import Tags, Warning, register [ef207409]

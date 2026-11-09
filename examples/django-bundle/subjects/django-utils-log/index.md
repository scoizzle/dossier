# django/utils/log

- Subject: django/utils/log (id `8892ab39-d0e9-4fee-a106-77921d07262e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2430 tokens
- Facts shown: 40 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # ... then invoke it with the logging settings if logging_settings: logging_config_func(logging_settings) [06a3c1f0]
- # RemovedInDjango2028Warning: email_backend arg and connection error. if email_backend: if using: raise ImproperlyConfigured( "The 'email_backend' argument is not compatible with 'using'." ) if mail.mailers._is_configured: raise ImproperlyConfigured( "The 'email_backend' argument is not valid when " "settings.MAILERS is defined." ) warnings.warn( "The 'email_backend' argument is deprecated. Use 'using' instead.", RemovedInDjango2028Warning, skip_file_prefixes=django_file_prefixes(), ) if hasattr(self, "connection"): raise AttributeError( "The undocumented AdminEmailHandler.connection() method is no longer " "used." ) [41e32621]
- # Since we add a nicely formatted traceback on our own, create a copy # of the log record without the exception data. no_exc_record = copy(record) no_exc_record.exc_info = None no_exc_record.exc_text = None [d900d9d4]
- if record.exc_info: exc_info = record.exc_info else: exc_info = (None, record.getMessage(), None) [00a87c9b]
- if self.uses_server_time() and not hasattr(record, "server_time"): record.server_time = self.formatTime(record, self.datefmt) [4461e045]
- if status_code: if 200 <= status_code < 300: # Put 2XX first, since it should be the common case msg = self.style.HTTP_SUCCESS(msg) elif 100 <= status_code < 200: msg = self.style.HTTP_INFO(msg) elif status_code == 304: msg = self.style.HTTP_NOT_MODIFIED(msg) elif 300 <= status_code < 400: msg = self.style.HTTP_REDIRECT(msg) elif status_code == 404: msg = self.style.HTTP_NOT_FOUND(msg) elif 400 <= status_code < 500: msg = self.style.HTTP_BAD_REQUEST(msg) else: # Any 5XX, or any other status code msg = self.style.HTTP_SERVER_ERROR(msg) [180f390b]
- logging.config.dictConfig(DEFAULT_LOGGING) [4c2d6694]
- record.msg = msg return super().format(record) [e99c7046]
- reporter = self.reporter_class(request, is_email=True, *exc_info) message = "%s\n\n%s" % ( self.format(no_exc_record), reporter.get_traceback_text(), ) html_message = reporter.get_traceback_html() if self.include_html else None self.send_mail(subject, message, html_message=html_message) [5dca970b]
- self.include_html = include_html self.email_backend = email_backend self.using = using self.reporter_class = import_string( reporter_class or settings.DEFAULT_EXCEPTION_REPORTER ) [1fdc92e4]
- try: mail.mail_admins(subject, message, *args, using=self.using, **kwargs) except mail.MailerDoesNotExist: pass [d006c373]
- """ extra = {"request": request, **extra} if status_code is not None: extra["status_code"] = status_code if level is None: if status_code >= 500: level = "error" elif status_code >= 400: level = "warning" [075c1915]
- Arguments from `args` will be escaped to avoid potential log injections. [faeb68d8]
- If the request is passed as the first argument to the log record, request data will be provided in the email report. """ [d85cb5eb]
- Pass `request`, `status_code` (if defined) and any provided `extra` as such to the logging method, [d799aaf8]

## All facts

- [2a84575f] Log 5xx responses as errors and 4xx responses as warnings (unless a level is given as a keyword argument). The HttpResponse status_code and the request are passed to the logger's extra parameter. """ # Check if the response has already been logged. Multiple requests to log # the same response can be received in some cases, e.g., when the # response is the result of an exception and is logged when the exception # is caught, to record the exception. if getattr(response, "_has_been_logged", False): return
- [e83f827c] def __init__( self, include_html=False, email_backend=None, reporter_class=None, using=None ): super().__init__()
- [64190a88] def __init__(self, *args, **kwargs): self.style = color_style() super().__init__(*args, **kwargs)
- [a2fbe6f2] def __init__(self, callback): self.callback = callback
- [a26c5f33] def emit(self, record): # Early return when no email will be sent. if ( not settings.ADMINS # Method not overridden. and self.send_mail.__func__ is AdminEmailHandler.send_mail ): return try: request = record.request subject = "%s (%s IP): %s" % ( record.levelname, ( "internal" if request.META.get("REMOTE_ADDR") in settings.INTERNAL_IPS else "EXTERNAL" ), record.getMessage(), ) except Exception: subject = "%s: %s" % (record.levelname, record.getMessage()) request = None subject = self.format_subject(subject)
- [61930388] def filter(self, record): if self.callback(record): return 1 return 0
- [49c5e50b] def format(self, record): msg = record.msg status_code = getattr(record, "status_code", None)
- [52265864] def format_subject(self, subject): """ Escape CR and LF characters. """ return subject.replace("\n", "\\n").replace("\r", "\\r")
- [ec3513b8] def send_mail(self, subject, message, *args, **kwargs): # RemovedInDjango2028Warning. if not mail.mailers._is_configured: connection = mail.get_connection( backend=self.email_backend, fail_silently=True ) mail.mail_admins(subject, message, *args, connection=connection, **kwargs) return
- [58adf0ee] def uses_server_time(self): return self._fmt.find("{server_time}") >= 0
- [88129781] escaped_args = tuple( a.encode("unicode_escape").decode("ascii") if isinstance(a, str) else a for a in args )
- [06635988] getattr(logger, level or "info")( message, *escaped_args, extra=extra, exc_info=exception, )
- [68208801] log_message( logger, message, *args, level=level, status_code=response.status_code, request=request, exception=exception, ) response._has_been_logged = True
- [32ce3176] # Default logging for Django. This sends an email to the site admins on every # HTTP 500 error. Depending on DEBUG, all other log records are either sent to # the console (DEBUG=True) or discarded (DEBUG=False) by means of the # require_debug_true filter. This configuration is quoted in # docs/ref/logging.txt; please amend it there if edited here. DEFAULT_LOGGING = { "version": 1, "disable_existing_loggers": False, "filters": { "require_debug_false": { "()": "django.utils.log.RequireDebugFalse", }, "require_debug_true": { "()": "django.utils.log.RequireDebugTrue", }, }, "formatters": { "django.server": { "()": "django.utils.log.ServerFormatter", "format": "[{server_time}] {message}", "style": "{", } }, "handlers": { "console": { "level": "INFO", "filters": ["require_debug_true"], "class": "logging.StreamHandler", }, "django.server": { "level": "INFO", "class": "logging.StreamHandler", "formatter": "django.server", }, "mail_admins": { "level": "ERROR", "filters": ["require_debug_false"], "class": "django.utils.log.AdminEmailHandler", }, }, "loggers": { "django": { "handlers": ["console", "mail_admins"], "level": "INFO", }, "django.server": { "handlers": ["django.server"], "level": "INFO", "propagate": False, }, }, }
- [7aed749e] class AdminEmailHandler(logging.Handler): """An exception log handler that emails log entries to site admins.
- [44586466] class CallbackFilter(logging.Filter): """ A logging filter that checks the return value of a given callable (which takes the record-to-be-logged as its only parameter) to decide whether to log a record. """
- [9d907639] class RequireDebugFalse(logging.Filter): def filter(self, record): return not settings.DEBUG
- [4d7df349] class RequireDebugTrue(logging.Filter): def filter(self, record): return settings.DEBUG
- [750f9e0a] class ServerFormatter(logging.Formatter): default_time_format = "%d/%b/%Y %H:%M:%S"
- [bff896c2] def configure_logging(logging_config, logging_settings): if logging_config: # First find the logging configuration function ... logging_config_func = import_string(logging_config)
- [fc753c4e] def log_message( logger, message, *args, level=None, status_code=None, request=None, exception=None, **extra, ): """Log `message` using `logger` based on `status_code` and logger `level`.
- [e393b69f] def log_response( message, *args, response=None, request=None, logger=request_logger, level=None, exception=None, ): """ Log errors based on HttpResponse status.
- [9b895278] from django.conf import settings from django.core import mail from django.core.exceptions import ImproperlyConfigured from django.core.management.color import color_style from django.utils.deprecation import RemovedInDjango2028Warning, django_file_prefixes from django.utils.module_loading import import_string
- [fd0d5d32] import logging import logging.config # needed when logging_config doesn't start with logging.config import warnings from copy import copy
- [aeef0cbf] request_logger = logging.getLogger("django.request")

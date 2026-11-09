# django/utils/log

- Subject: django/utils/log (id `cbaf2ae3-c27e-411e-b5d5-d998f1aa992a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 877 tokens
- Facts shown: 15 of 40
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

25 more facts did not fit in the budget: [2a84575f] [e83f827c] [64190a88] [a2fbe6f2] [a26c5f33] [61930388] [49c5e50b] [52265864] [ec3513b8] [58adf0ee] [88129781] [06635988] [68208801] [32ce3176] [7aed749e] [44586466] [9d907639] [4d7df349] [750f9e0a] [bff896c2] [fc753c4e] [e393b69f] [9b895278] [fd0d5d32] [aeef0cbf]

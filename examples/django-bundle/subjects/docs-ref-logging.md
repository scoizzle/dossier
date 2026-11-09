# docs/ref/logging

- Subject: docs/ref/logging (id `8138c6d0-cff5-44b4-bde0-44c610822804`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 20 of 118
- Conflicts: 0
- Gaps: 0

## Facts

- "handlers": { "mail_admins": { "level": "ERROR", "class": "django.utils.log.AdminEmailHandler", "include_html": True, "reporter_class": "somepackage.error_reporter.CustomErrorReporter", }, } [d2cef61a]
- "handlers": { "mail_admins": { "level": "ERROR", "class": "django.utils.log.AdminEmailHandler", "include_html": True, }, } [147f314f]
- "handlers": { "mail_admins": { "level": "ERROR", "class": "django.utils.log.AdminEmailHandler", "using": "internal", }, } [217d97be]
- LOGGING = { # ... "filters": { "require_debug_false": { "()": "django.utils.log.RequireDebugFalse", }, }, "handlers": { "mail_admins": { "level": "ERROR", "filters": ["require_debug_false"], "class": "django.utils.log.AdminEmailHandler", }, }, # ... } [975ac354]
- LOGGING = { # ... "filters": { "skip_unreadable_posts": { "()": "django.utils.log.CallbackFilter", "callback": skip_unreadable_post, }, }, "handlers": { "mail_admins": { "level": "ERROR", "filters": ["skip_unreadable_posts"], "class": "django.utils.log.AdminEmailHandler", }, }, # ... } [434b16dd]
- Sends emails to admin users. To customize this behavior, you can subclass the :class:`~django.utils.log.AdminEmailHandler` class and override this method. [cfe19f04]
- The ``email_backend`` argument is deprecated. Use ``using`` instead. [9dd5ce7d]
- The ``using`` argument was added. [b2c2abaf]
- def skip_unreadable_post(record): if record.exc_info: exc_type, exc_value = record.exc_info[:2] if isinstance(exc_value, UnreadablePostError): return False return True [a24efbd7]
- from django.http import UnreadablePostError [37e49ddd]
- * :ref:`logging-how-to` * :ref:`Django logging overview <logging-explanation>` [4e7a708b]
- .. deprecated:: 6.1 [01aaf10861da6524-7]
- .. method:: send_mail(subject, message, *args, **kwargs) [6176f0e8]
- .. versionchanged:: 6.1 [2a966a198e13032b-11]
- Be aware of the :ref:`security implications of logging <logging-security-implications>` when using the ``AdminEmailHandler``. [39209cc6]
- By setting the deprecated ``email_backend`` argument of ``AdminEmailHandler``, the :ref:`email backend <topic-email-backends>` that is being used by the handler can be overridden. ``email_backend`` is not supported when :setting:`MAILERS` is defined or when the ``using`` argument is provided. [d91dcee8]
- Email is sent using the default :ref:`mailer <topic-email-configuration>`. This can be overridden by setting the ``using`` argument of ``AdminEmailHandler``, like this:: [3a03aa64]
- For instance, to filter out :exc:`~django.http.UnreadablePostError` (raised when a user cancels an upload) from the admin emails, you would create a filter function:: [96a18357]
- If the log record contains a ``request`` attribute, the full details of the request will be included in the email. The email subject will include the phrase "internal IP" if the client's IP address is in the :setting:`INTERNAL_IPS` setting; if not, it will include "EXTERNAL IP". [0e0c556f]
- This filter will only pass on records when settings.DEBUG is False. [a9e6b9fe]

## Beyond the budget

95 more facts did not fit in the budget: [f1623cb3] [b30846dd] [c28d34f9] [8a340998] [fedc4c7f] [d42bbcfe] [8b949128] [99c20f63] [21b0cd1e] [03e5b2ba] [bc731785] [e07e3df0] [1f32ed53] [4d544186] [dac637fb] [91081010] [2cb79eec] [9fa80e60] [628b6b8f] [7737f82f] [0f50863a] [15519afdcb00292a] [0bf848a9] [cec061c2] [c168a10a] [244a6f62] [f34e4305] [3e4b28b5] [8b2c4626] [d4a99d42] [4f56eb8c] [2f8a96a4] [012da8c3] [5f0ef663] [c0b0fbf3] [b9bbba2e] [fbe5cb09] [1e38058f] [6db6cfea] [e691bae1] [1432756e] [6b4a5e54e001d097-23] [e82d3d21] [563e22f8] [1c6d9e06] [9cd048ec] [bbf882f9] [c71a84eb] [6ecdb48c] [b370db80] [fde9b8d5] [8250bd8a] [58b29a07] [5e930094] [b5ec857c] [6ea95ee4] [0ec1d112] [989f5491] [b3fbf37d] [54e54b4d] [fe2d643b] [6ffaec13] [01cbf129] [45af48bc] [30cedeb2] [686bd8cb] [b9e091ca] [116627e1] [cec6e322] [11a0b8f0] [7b974f1ed9128450] [579b55de] [de93e087] [2c76f724] [0b19799b] [f97c5c4a] [37e46b8a] [619f476b] [19ede57e] [9154ebef] [99e3b8cc] [668fb3a4] [89b0c907] [e2b3fc2a] [618a4ae7] [1a0afc63] [68175637] [a413548f] [92762c4c] [2def0e22] [b6fd0402] [706731df] [6ee1e3d4] [a0d5e957] [774053b0]

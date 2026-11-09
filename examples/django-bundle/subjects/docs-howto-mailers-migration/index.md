# docs/howto/mailers-migration

- Subject: docs/howto/mailers-migration (id `29ff0e76-a4ee-4733-81ba-b9d17ce0c2a7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 21 of 117
- Conflicts: 0
- Gaps: 0

## Facts

- MAILERS = { "default": {...}, "custom": { "BACKEND": "path.to.custom.EmailBackend", "OPTIONS": { "option1": True, "option2": "value", }, }, } [dade1b13]
- connection = mail.get_connection( "path.to.custom.EmailBackend", option1=True, option2="value" ) mail.send_mail(..., connection=connection) connection.send_messages([email1, email2]) [bc7eb5aa]
- connection = mail.get_connection() connection.send_messages([email1, email2]) [a82ba8ac]
- connection = mail.mailers.default connection.send_messages([email1, email2]) [632ec2c1]
- mail.send_mail(...) # No connection arg needed. [e5d930ab]
- mail.send_mail(..., connection=mail.get_connection()) [c7986474]
- mail.send_mail(..., using="custom") mail.mailers["custom"].send_messages([email1, email2]) [95f06e0a]
- Consider running with deprecation warnings enabled in production to catch those deprecations. Or carefully review your code (including third-party packages) for use of any deprecated email features. [4b22ea92]
- Running tests may not identify all relevant deprecations. Test suites often use a non-functional email backend (such as the memory backend that Django :ref:`substitutes during tests <topics-testing-email>`), so can miss deprecation warnings that are only issued from the production email configuration. [402288d1]
- * :func:`.mail.get_connection` and the ``connection`` arguments to mail functions [0fe9fd41]
- * :setting:`EMAIL_BACKEND`, :setting:`EMAIL_FILE_PATH`, :setting:`EMAIL_HOST`, :setting:`EMAIL_HOST_PASSWORD`, :setting:`EMAIL_HOST_USER`, :setting:`EMAIL_PORT`, :setting:`EMAIL_SSL_CERTFILE`, :setting:`EMAIL_SSL_KEYFILE`, :setting:`EMAIL_TIMEOUT`, :setting:`EMAIL_USE_SSL`, :setting:`EMAIL_USE_TLS` [ce81f45b]
- * The ``auth_user`` and ``auth_password`` arguments to :func:`.send_mail` and :func:`.send_mass_mail` [9a6ba605]
- * The ``email_backend`` argument to :class:`.AdminEmailHandler` [bc9d1abc]
- * The ``fail_silently`` argument to :func:`.send_mail`, :func:`.send_mass_mail`, :func:`.mail_admins`, :func:`.mail_managers`, and :meth:`.EmailMessage.send` [420bc3cf]
- And then use it like this:: [466d72c6]
- Define a custom :setting:`MAILERS` configuration in your settings:: [88ae3968]
- Define a custom :setting:`MAILERS` configuration with the desired backend and options. Then refer to it in the ``using`` argument when sending mail, or obtain an email backend instance from :data:`.mail.mailers` with the configuration name. [2e4aa445]
- EMAIL_BACKEND = "django.core.mail.backends.smtp.EmailBackend" EMAIL_HOST = "mail.example.net" EMAIL_USE_TLS = True EMAIL_PORT = 587 EMAIL_HOST_USER = "user@example.net" EMAIL_HOST_PASSWORD = "password" [01e79695]
- For example, to upgrade this code:: [2ab3e9a5]
- LOGGING = { # ... "handlers": { "mail_admins": { "class": "django.utils.log.AdminEmailHandler", "email_backend": "third.party.EmailBackend", }, }, # ... } [e1459210]
- MAILERS = { "default": {...}, "admin-logging": { "BACKEND": "third.party.EmailBackend", }, } [e54a9896]

## Beyond the budget

96 more facts did not fit in the budget: [ee8a0c7e] [d70bfe4b] [9444e5aa] [f9427396] [daf9b29d] [7d470701] [f3dd3f7d] [dcf70f85] [eccc06cb] [d727c74f] [9949c2a3] [9e7915a2] [f4a8e80a] [f6ea6340] [2878f445] [b86248b8] [942ae6c11625c81c-8] [0e66e7eb] [41e0d4e3] [d0b2aa5a] [fefe609e] [419de5ff] [0217bb80] [9e923e26] [928923ca] [1917e347] [7ee51ce2] [933da34f] [116f846c] [baab344a] [36cd9f6a] [cb96f5ce] [5eb6d4e9] [1539769e] [07306314] [38845234] [2f365a25] [c26950c2] [ef615197] [908fd3f7] [018ee1cd] [c0d19d94] [983662ea] [5140affd] [e4801264] [d2062181] [3549fd4f] [a267bfb4] [3a5e097b] [57cf13a3] [01aaf10861da6524] [27e91f6e] [444a87aa] [572c45c0] [116d0abd] [eef0c4db] [7a951425] [e7cbc4a3] [2335e841] [7c4daff9] [8e87d75f] [49f8bf82] [6c21e2d3] [a4521799] [e91fb26b] [0dc84c64] [230477ea] [eaa686c6] [9acb991b] [62456de5] [873145dd] [c767e262] [1deb8b0c] [0cfab2be] [297cc486] [0af35d42] [633de52f] [0a8cd275] [7d0de0c6] [9df31050] [9f2ece1c] [3561651a] [95147206] [f4e558fd] [5eacec64] [c4f82559] [b8093fb4] [cc287a50] [b14e2159] [44c14dc7] [d963494e] [d96ff7c7] [494cdb5d] [eb17411c] [6fdeaf0a] [1480bd0f]

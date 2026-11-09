# docs/howto/logging

- Subject: docs/howto/logging (id `11bc2002-6783-4820-be8a-29fadcfce096`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 26 of 90
- Conflicts: 0
- Gaps: 0

## Facts

- "handlers": { "file": { "class": "logging.FileHandler", "filename": "general.log", "formatter": "verbose", }, } [1ae84670]
- "level": os.getenv("DJANGO_LOG_LEVEL", "WARNING") [9dfd0c02]
- * :ref:`Django logging reference <logging-ref>` * :ref:`Django logging overview <logging-explanation>` [f7417ae6]
- LOGGING = { "version": 1, # the dictConfig format version "disable_existing_loggers": False, # retain the default loggers } [a5f17f46]
- LOGGING = { # ... "formatters": { "verbose": { "format": "{name} {levelname} {asctime} {module} {process:d} {thread:d} {message}", "style": "{", }, "simple": { "format": "{levelname} {message}", "style": "{", }, }, } [c27ba2a7]
- LOGGING = { # ... "handlers": { "file": { "class": "logging.FileHandler", "filename": "general.log", }, }, } [db919840]
- LOGGING = { # ... "loggers": { "": { "level": "DEBUG", "handlers": ["file"], }, }, } [e8fdc42b]
- LOGGING = { # ... "loggers": { "my_app": { # ... }, "my_app.views": { # ... }, "my_app.views.private": { # ... "propagate": False, }, }, } [802ceb2b]
- LOGGING = { # ... "loggers": { "my_app": {...}, }, } [757fa6e3]
- LOGGING = { # ... "loggers": { "my_app.views": {...}, }, } [168df9b4]
- Records with a level lower than ``WARNING`` will not appear in the console by default. Changing this behavior requires additional configuration. [cf55f2e6]
- The way that Django logging is configured as part of the ``setup()`` function means that logging calls placed in ``settings.py`` may not work as expected, because *logging will not be set up at that point*. To explore logging, use a view function as suggested in the example below. [a16cb01c]
- def some_view(request): ... if some_risky_state: logger.warning("Platform is running at risk") [074dc0d2]
- import logging [50c88141]
- logger = logging.getLogger("project.payment") [794dfd32]
- logger = logging.getLogger(__name__) [6bedbb626d39929f]
- logger.critical("Payment system is not responding") [cec738da]
- logger.debug("Attempting to connect to API") [4515c445]
- { "class": "logging.FileHandler", "filename": "general.log", "level": "DEBUG", } [2eb450c6]
- * logger mappings, to determine which records are sent to which handlers * handlers, to determine what they do with the records they receive * filters, to provide additional control over the transfer of records, and even modify records in-place * formatters, to convert :class:`~logging.LogRecord` objects to a string or other form for consumption by human beings or another system [924a9bc6]
- .. _basic-logger-configuration: [5f3cbc03]
- .. _logging-how-to: [fc3e0ea7]
- .. _naming-loggers-hierarchy: [e07666b8]
- .. _naming-loggers: [2267e6a0]
- .. admonition:: Don't be tempted to use logging calls in ``settings.py``. [1d76b413]
- .. code-block:: python :emphasize-lines: 3-12 [d95ba495]

## Beyond the budget

60 more facts did not fit in the budget: [bb65b26e7c242781] [0ddc325a84512bdf] [a5d95d79] [46fe41aa] [6b4a5e54e001d097-7] [334e3930] [23e1eed2] [21030f4f] [91d8ae11] [4e3c8841] [b1009f96] [61c8c7e2] [93970bab] [f268c91c] [4b41e271] [04d6b8bd] [502babc1] [0c2580e1] [99d25240] [52307cce] [e5ce9f8b] [d9b25098] [c2f8679d] [dc549582] [3182cbb8] [caba67f7] [6e62d1fc] [882f4b72] [35af9c5a] [21a8679f] [a766737e] [af0d1ad8] [5ffe2a91] [97364e8d] [37762658] [203e18cc] [69d6a5f7] [2ccb6832] [3d4277e2] [8fe51284] [914a5cd0] [ff2606c7] [51317790] [94e25352] [b477c078] [d450a320] [3b47cf58] [a6d5f1d8] [0e1778c4] [015478aa] [7cf5c026] [e3b854d6] [23b36c31] [81aa9448] [64995ad9] [d0bd259b] [3367ba92] [6db15d39] [38cac8be] [0396a086]

# docs/releases/1.6.10

- Subject: docs/releases/1.6.10 (id `dc84b40c-6570-44cb-a592-1e907e93a307`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1038 tokens
- Facts shown: 14 of 14
- Conflicts: 0
- Gaps: 0

## Highlights

- *January 13, 2015* [388fbb2cbb8cb1d7-2]
- =========================== Django 1.6.10 release notes =========================== [2a9693a6]
- Database denial-of-service with ``ModelMultipleChoiceField`` ============================================================ [0c9ceb45]
- Denial-of-service attack against ``django.views.static.serve`` ============================================================== [990caf9590cf689d-2]
- Django 1.6.10 fixes several security issues in 1.6.9. [30895a72]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()`` and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) didn't strip leading whitespace on the tested URL and as such considered URLs like ``\njavascript:...`` safe. If a developer relied on ``is_safe_url()`` to provide safe redirect targets and put such a URL into a link, they could suffer from a XSS attack. This bug doesn't affect Django currently, since we only put this URL into the ``Location`` response header and browsers seem to ignore JavaScript there. [964340ca5ad24fcf-2]
- Given a form that uses ``ModelMultipleChoiceField`` and ``show_hidden_initial=True`` (not a documented API), it was possible for a user to cause an unreasonable number of SQL queries by submitting duplicate values for the field's data. The validation logic in ``ModelMultipleChoiceField`` now deduplicates submitted values to address this issue. [20184fec]
- In older versions of Django, the :func:`django.views.static.serve` view read the files it served one line at a time. Therefore, a big file with no newlines would result in memory usage equal to the size of that file. An attacker could exploit this and launch a denial-of-service attack by simultaneously requesting many large files. This view now reads the file in chunks to prevent large memory usage. [2c129ddde54e5c96-2]
- In order to prevent such attacks, both Nginx and Apache 2.4+ strip all headers containing underscores from incoming requests by default. Django's built-in development server now does the same. Django's development server is not recommended for production use, but matching the behavior of common production servers reduces the surface area for behavior changes during deployment. [928574923ab830cb-2]
- Mitigated possible XSS attack via user-supplied redirect URLs ============================================================= [7d730b5e3df549c3-5]
- Note, however, that this view has always carried a warning that it is not hardened for production use and should be used only as a development aid. Now may be a good time to audit your project and serve your files in production using a real front-end web server if you are not doing so. [a23649e83451c23d-2]
- WSGI header spoofing via underscore/dash conflation =================================================== [07908c11312a74a1-2]
- When HTTP headers are placed into the WSGI environ, they are normalized by converting to uppercase, converting all dashes to underscores, and prepending ``HTTP_``. For instance, a header ``X-Auth-User`` would become ``HTTP_X_AUTH_USER`` in the WSGI environ (and thus also in Django's ``request.META`` dictionary). [4dc4c57eb359d1d7-2]

## All facts

- [e1be48d382b77261-2] Unfortunately, this means that the WSGI environ cannot distinguish between headers containing dashes and headers containing underscores: ``X-Auth-User`` and ``X-Auth_User`` both become ``HTTP_X_AUTH_USER``. This means that if a header is used in a security-sensitive way (for instance, passing authentication information along from a front-end proxy), even if the proxy carefully strips any incoming value for ``X-Auth-User``, an attacker may be able to provide an ``X-Auth_User`` header (with underscore) and bypass this protection.

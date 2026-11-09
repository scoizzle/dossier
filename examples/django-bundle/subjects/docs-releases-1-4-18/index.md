# docs/releases/1.4.18

- Subject: docs/releases/1.4.18 (id `7e8c55bb-f56c-473e-80f8-3a0eca3d7cd8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 985 tokens
- Facts shown: 14 of 14
- Conflicts: 0
- Gaps: 0

## Highlights

- * To maintain compatibility with Python 2.5, Django's vendored version of six, ``django.utils.six``, has been downgraded to 1.8.0 which is the last version to support Python 2.5. [73f6e8cc]
- *January 13, 2015* [388fbb2cbb8cb1d7]
- =========================== Django 1.4.18 release notes =========================== [203206ec]
- Bugfixes ======== [6c84539cac9c976c-32]
- Denial-of-service attack against ``django.views.static.serve`` ============================================================== [990caf9590cf689d]
- Django 1.4.18 fixes several security issues in 1.4.17 as well as a regression on Python 2.5 in the 1.4.17 release. [80dfc01c]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()`` and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) didn't strip leading whitespace on the tested URL and as such considered URLs like ``\njavascript:...`` safe. If a developer relied on ``is_safe_url()`` to provide safe redirect targets and put such a URL into a link, they could suffer from a XSS attack. This bug doesn't affect Django currently, since we only put this URL into the ``Location`` response header and browsers seem to ignore JavaScript there. [964340ca5ad24fcf]
- In older versions of Django, the :func:`django.views.static.serve` view read the files it served one line at a time. Therefore, a big file with no newlines would result in memory usage equal to the size of that file. An attacker could exploit this and launch a denial-of-service attack by simultaneously requesting many large files. This view now reads the file in chunks to prevent large memory usage. [2c129ddde54e5c96]
- In order to prevent such attacks, both Nginx and Apache 2.4+ strip all headers containing underscores from incoming requests by default. Django's built-in development server now does the same. Django's development server is not recommended for production use, but matching the behavior of common production servers reduces the surface area for behavior changes during deployment. [928574923ab830cb]
- Mitigated possible XSS attack via user-supplied redirect URLs ============================================================= [7d730b5e3df549c3]
- Note, however, that this view has always carried a warning that it is not hardened for production use and should be used only as a development aid. Now may be a good time to audit your project and serve your files in production using a real front-end web server if you are not doing so. [a23649e83451c23d]
- Unfortunately, this means that the WSGI environ cannot distinguish between headers containing dashes and headers containing underscores: ``X-Auth-User`` and ``X-Auth_User`` both become ``HTTP_X_AUTH_USER``. This means that if a header is used in a security-sensitive way (for instance, passing authentication information along from a front-end proxy), even if the proxy carefully strips any incoming value for ``X-Auth-User``, an attacker may be able to provide an ``X-Auth_User`` header (with underscore) and bypass this protection. [e1be48d382b77261]
- WSGI header spoofing via underscore/dash conflation =================================================== [07908c11312a74a1]

## All facts

- [4dc4c57eb359d1d7] When HTTP headers are placed into the WSGI environ, they are normalized by converting to uppercase, converting all dashes to underscores, and prepending ``HTTP_``. For instance, a header ``X-Auth-User`` would become ``HTTP_X_AUTH_USER`` in the WSGI environ (and thus also in Django's ``request.META`` dictionary).

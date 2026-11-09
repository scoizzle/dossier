# docs/releases/1.4.6

- Subject: docs/releases/1.4.6 (id `267c3411-7340-409d-9e91-df6d504bf7d3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 417 tokens
- Facts shown: 8 facts
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed an obscure bug with the :func:`~django.test.override_settings` decorator. If you hit an ``AttributeError: 'Settings' object has no attribute '_original_allowed_hosts'`` exception, it's probably fixed (#20636). [e4c765e5]
- *August 13, 2013* [bd26aac53d00c628]
- ========================== Django 1.4.6 release notes ========================== [49448b59]
- Bugfixes ======== [6c84539cac9c976c-34]
- Django 1.4.6 fixes one security issue present in previous Django releases in the 1.4 series, as well as one other bug. [3e6f6e24]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()``, ``django.contrib.comments``, and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) didn't check if the scheme is ``http(s)`` and as such allowed ``javascript:...`` URLs to be entered. If a developer relied on ``is_safe_url()`` to provide safe redirect targets and put such a URL into a link, they could suffer from a XSS attack. This bug doesn't affect Django currently, since we only put this URL into the ``Location`` response header and browsers seem to ignore JavaScript there. [4425261a0f33ad28]
- Mitigated possible XSS attack via user-supplied redirect URLs ============================================================= [7d730b5e3df549c3-3]
- This is the sixth bugfix/security release in the Django 1.4 series. [4aec4e73]

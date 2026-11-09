# docs/releases/1.4.20

- Subject: docs/releases/1.4.20 (id `141abade-c358-4cc7-9cc4-6a420255fdeb`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 371 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- *March 18, 2015* [04d000b66d37a744]
- =========================== Django 1.4.20 release notes =========================== [f03efe5d]
- Django 1.4.20 fixes one security issue in 1.4.19. [f79da350]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()`` and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) accepted URLs with leading control characters and so considered URLs like ``\x08javascript:...`` safe. This issue doesn't affect Django currently, since we only put this URL into the ``Location`` response header and browsers seem to ignore JavaScript there. Browsers we tested also treat URLs prefixed with control characters such as ``%08//example.com`` as relative paths so redirection to an unsafe target isn't a problem either. [77db140f465e5636]
- However, if a developer relies on ``is_safe_url()`` to provide safe redirect targets and puts such a URL into a link, they could suffer from an XSS attack as some browsers such as Google Chrome ignore control characters at the start of a URL in an anchor ``href``. [7709adcff5fc2f4b]
- Mitigated possible XSS attack via user-supplied redirect URLs ============================================================= [7d730b5e3df549c3-2]

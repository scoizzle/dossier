# docs/releases/1.6.11

- Subject: docs/releases/1.6.11 (id `052d412c-fa87-4757-b34d-06c9c5ee17da`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 645 tokens
- Facts shown: 9 facts
- Conflicts: 0
- Gaps: 0

## Facts

- *March 18, 2015* [04d000b66d37a744-2]
- =========================== Django 1.6.11 release notes =========================== [015d2b6c]
- Denial-of-service possibility with ``strip_tags()`` =================================================== [c7918479]
- Django 1.6.11 fixes two security issues in 1.6.10. [67ec3341]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()`` and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) accepted URLs with leading control characters and so considered URLs like ``\x08javascript:...`` safe. This issue doesn't affect Django currently, since we only put this URL into the ``Location`` response header and browsers seem to ignore JavaScript there. Browsers we tested also treat URLs prefixed with control characters such as ``%08//example.com`` as relative paths so redirection to an unsafe target isn't a problem either. [77db140f465e5636-2]
- However, if a developer relies on ``is_safe_url()`` to provide safe redirect targets and puts such a URL into a link, they could suffer from an XSS attack as some browsers such as Google Chrome ignore control characters at the start of a URL in an anchor ``href``. [7709adcff5fc2f4b-2]
- Last year :func:`~django.utils.html.strip_tags` was changed to work iteratively. The problem is that the size of the input it's processing can increase on each iteration which results in an infinite loop in ``strip_tags()``. This issue only affects versions of Python that haven't received :bpo:`a bugfix in HTMLParser <20288>`; namely Python < 2.7.7 and 3.3.5. Some operating system vendors have also backported the fix for the Python bug into their packages of earlier versions. [43d3696e]
- Mitigated possible XSS attack via user-supplied redirect URLs ============================================================= [7d730b5e3df549c3-6]
- To remedy this issue, ``strip_tags()`` will now return the original input if it detects the length of the string it's processing increases. Remember that absolutely NO guarantee is provided about the results of ``strip_tags()`` being HTML safe. So NEVER mark safe the result of a ``strip_tags()`` call without escaping it first, for example with :func:`~django.utils.html.escape`. [c376e6cd]

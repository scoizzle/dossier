# docs/releases/1.11.23

- Subject: docs/releases/1.11.23 (id `9db0cef8-03fb-4be0-8eea-64ebb3a44351`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 861 tokens
- Facts shown: 15 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- *August 1, 2019* [b31eacfd]
- :lookup:`Key and index lookups <jsonfield.key>` for ``django.contrib.postgres.fields.JSONField`` and :lookup:`key lookups <hstorefield.key>` for :class:`~django.contrib.postgres.fields.HStoreField` were subject to SQL injection, using a suitably crafted dictionary, with dictionary expansion, as the ``**kwargs`` passed to ``QuerySet.filter()``. [1e9b4b07]
- ============================ Django 1.11.23 release notes ============================ [a0f1e710]
- CVE-2019-14232: Denial-of-service possibility in ``django.utils.text.Truncator`` ================================================================================ [c32a5ec7]
- CVE-2019-14233: Denial-of-service possibility in ``strip_tags()`` ================================================================= [36652c19]
- CVE-2019-14234: SQL injection possibility in key and index lookups for ``JSONField``/``HStoreField`` ==================================================================================================== [76764898]
- CVE-2019-14235: Potential memory exhaustion in ``django.utils.encoding.uri_to_iri()`` ===================================================================================== [0d2e71bf]
- Django 1.11.23 fixes security issues in 1.11.22. [ed0779df]
- Due to the behavior of the underlying ``HTMLParser``, :func:`django.utils.html.strip_tags` would be extremely slow to evaluate certain inputs containing large sequences of nested incomplete HTML entities. The ``strip_tags()`` method is used to implement the corresponding :tfilter:`striptags` template filter, which was thus also vulnerable. [9eb79c68]
- If ``django.utils.text.Truncator``'s ``chars()`` and ``words()`` methods were passed the ``html=True`` argument, they were extremely slow to evaluate certain inputs due to a catastrophic backtracking vulnerability in a regular expression. The ``chars()`` and ``words()`` methods are used to implement the :tfilter:`truncatechars_html` and :tfilter:`truncatewords_html` template filters, which were thus vulnerable. [636556f1]
- If passed certain inputs, :func:`django.utils.encoding.uri_to_iri` could lead to significant memory usage due to excessive recursion when re-percent-encoding invalid UTF-8 octet sequences. [61fff13f]
- Remember that absolutely NO guarantee is provided about the results of ``strip_tags()`` being HTML safe. So NEVER mark safe the result of a ``strip_tags()`` call without escaping it first, for example with :func:`django.utils.html.escape`. [95679a8b]
- The regular expressions used by ``Truncator`` have been simplified in order to avoid potential backtracking issues. As a consequence, trailing punctuation may now at times be included in the truncated output. [a9726a42]
- ``strip_tags()`` now avoids recursive calls to ``HTMLParser`` when progress removing tags, but necessarily incomplete HTML entities, stops being made. [044ef29d]
- ``uri_to_iri()`` now avoids recursion when re-percent-encoding invalid UTF-8 octet sequences. [6c95b72f]

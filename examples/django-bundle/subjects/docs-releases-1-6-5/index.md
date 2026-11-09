# docs/releases/1.6.5

- Subject: docs/releases/1.6.5 (id `b1048dfa-1857-4894-88a3-0b8ade7837f1`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 867 tokens
- Facts shown: 16 facts
- Conflicts: 0
- Gaps: 0

## Facts

- * Avoided overwriting data fetched by ``select_related()`` in certain cases which could cause minor performance regressions (:ticket:`22508`). [6c9bedf7]
- * Fixed ``pgettext_lazy`` crash when receiving bytestring content on Python 2 (:ticket:`22565`). [5efbddb2]
- * Fixed the SQL generated when filtering by a negated ``Q`` object that contains a ``F`` object. (:ticket:`22429`). [4ada25ee]
- * Made the ``year_lookup_bounds_for_datetime_field`` Oracle backend method Python 3 compatible (:ticket:`22551`). [658ae07b]
- *May 14, 2014* [05a1c3ff4ffe8192-3]
- ========================== Django 1.6.5 release notes ========================== [29939200]
- Bugfixes ======== [6c84539cac9c976c-45]
- Django 1.6.5 fixes two security issues and several bugs in 1.6.4. [d7dd02e1]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()``, ``django.contrib.comments``, and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) did not correctly validate some malformed URLs, such as ``http:\\\\\\djangoproject.com``, which are accepted by some browsers with more liberal URL parsing. [dbe166c4df8bc636-3]
- In certain situations, Django may allow caches to store private data related to a particular session and then serve that data to requests with a different session, or no session at all. This can lead to information disclosure and can be a vector for cache poisoning. [b0ea10e6d928a326-3]
- Issue: Caches may incorrectly be allowed to store and serve private data ======================================================================== [ec719a8c]
- Issue: Malformed redirect URLs from user input not correctly validated ====================================================================== [e26206c2]
- The validation for redirects did not correctly validate some malformed URLs, which are accepted by some browsers. This allows a user to be redirected to an unsafe URL unexpectedly. [a52bce171eb95134-3]
- To remedy this, the special behavior for these older Internet Explorer versions has been removed, and the ``Vary`` header is no longer stripped from the response. In addition, modifications to the ``Cache-Control`` header for all Internet Explorer requests with a ``Content-Disposition`` header have also been removed as they were found to have similar issues. [512baf9d721b4a6a-3]
- To remedy this, the validation in ``is_safe_url()`` has been tightened to be able to handle and correctly validate these malformed URLs. [aafab6361665372c-3]
- When using Django sessions, Django will set a ``Vary: Cookie`` header to ensure caches do not serve cached data to requests from other sessions. However, older versions of Internet Explorer (most likely only Internet Explorer 6, and Internet Explorer 7 if run on Windows XP or Windows Server 2003) are unable to handle the ``Vary`` header in combination with many content types. Therefore, Django would remove the header if the request was made by Internet Explorer. [3dc7a20f49189052-3]

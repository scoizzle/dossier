# docs/releases/1.5.8

- Subject: docs/releases/1.5.8 (id `8db7804b-2071-4ea6-b41d-ed08103b5fe1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 682 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- *May 14, 2014* [05a1c3ff4ffe8192-2]
- ========================== Django 1.5.8 release notes ========================== [28f4de94]
- Caches may incorrectly be allowed to store and serve private data ================================================================= [cd71cffff65251c1-2]
- Django 1.5.8 fixes two security issues in 1.5.8. [534b5e7b]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()``, ``django.contrib.comments``, and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) did not correctly validate some malformed URLs, such as ``http:\\\\\\djangoproject.com``, which are accepted by some browsers with more liberal URL parsing. [dbe166c4df8bc636-2]
- In certain situations, Django may allow caches to store private data related to a particular session and then serve that data to requests with a different session, or no session at all. This can lead to information disclosure and can be a vector for cache poisoning. [b0ea10e6d928a326-2]
- Malformed redirect URLs from user input not correctly validated =============================================================== [218f2fafd68df071-2]
- The validation for redirects did not correctly validate some malformed URLs, which are accepted by some browsers. This allows a user to be redirected to an unsafe URL unexpectedly. [a52bce171eb95134-2]
- To remedy this, the special behavior for these older Internet Explorer versions has been removed, and the ``Vary`` header is no longer stripped from the response. In addition, modifications to the ``Cache-Control`` header for all Internet Explorer requests with a ``Content-Disposition`` header have also been removed as they were found to have similar issues. [512baf9d721b4a6a-2]
- To remedy this, the validation in ``is_safe_url()`` has been tightened to be able to handle and correctly validate these malformed URLs. [aafab6361665372c-2]
- When using Django sessions, Django will set a ``Vary: Cookie`` header to ensure caches do not serve cached data to requests from other sessions. However, older versions of Internet Explorer (most likely only Internet Explorer 6, and Internet Explorer 7 if run on Windows XP or Windows Server 2003) are unable to handle the ``Vary`` header in combination with many content types. Therefore, Django would remove the header if the request was made by Internet Explorer. [3dc7a20f49189052-2]

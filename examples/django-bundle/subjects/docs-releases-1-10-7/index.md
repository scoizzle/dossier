# docs/releases/1.10.7

- Subject: docs/releases/1.10.7 (id `05011ac9-d89f-4b77-9d57-79ec68816dbd`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 526 tokens
- Facts shown: 12 facts
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed model form ``default`` fallback for ``SelectMultiple`` (:ticket:`27993`). [db30ed49]
- * Made admin's ``RelatedFieldWidgetWrapper`` use the wrapped widget's ``value_omitted_from_data()`` method (:ticket:`27905`). [963b379e]
- *April 4, 2017* [7afc10e3cb48f02d]
- =========================== Django 1.10.7 release notes =========================== [3e66f46c]
- A maliciously crafted URL to a Django site using the :func:`~django.views.static.serve` view could redirect to any other domain. The view no longer does any redirects as they don't provide any known, useful functionality. [d48f87c2]
- Also, if a developer relies on ``is_safe_url()`` to provide safe redirect targets and puts such a URL into a link, they could suffer from an XSS attack. [c9c5aa2f]
- Bugfixes ======== [6c84539cac9c976c-7]
- CVE-2017-7233: Open redirect and possible XSS attack via user-supplied numeric redirect URLs ============================================================================================ [47f1693b]
- CVE-2017-7234: Open redirect vulnerability in ``django.views.static.serve()`` ============================================================================= [a85a0d42]
- Django 1.10.7 fixes two security issues and a bug in 1.10.6. [37613530]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()`` and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security check for these redirects (namely ``django.utils.http.is_safe_url()``) considered some numeric URLs (e.g. ``http:999999999``) "safe" when they shouldn't be. [fee5b232]
- Note, however, that this view has always carried a warning that it is not hardened for production use and should be used only as a development aid. [4e084322]

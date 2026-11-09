# docs/releases/1.4.2

- Subject: docs/releases/1.4.2 (id `b96a7dee-0f0c-468c-83af-1178a2650cc4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 813 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- Host: validsite.com:random@evilsite.com [734a22451cf5909c-2]
- * Subclass HTMLParser only for appropriate Python versions (#18239). * Added batch_size argument to qs.bulk_create() (#17788). * Fixed a small regression in the admin filters where wrongly formatted dates passed as url parameters caused an unhandled ValidationError (#18530). * Fixed an endless loop bug when accessing permissions in templates (#18979) * Fixed some Python 2.5 compatibility issues * Fixed an issue with quoted filenames in Content-Disposition header (#19006) * Made the context option in ``trans`` and ``blocktrans`` tags accept literals wrapped in single quotes (#18881). * Numerous documentation improvements and fixes. [8eec70f8]
- * The newly introduced :class:`~django.db.models.GenericIPAddressField` constructor arguments have been adapted to match those of all other model fields. The first two keyword arguments are now verbose_name and name. [b7ef005c]
- *October 17, 2012* [7a7a276601f4095f-2]
- .. _security advisory: https://www.djangoproject.com/weblog/2012/oct/17/security/ [79e651a800ca5dba-2]
- .. code-block:: text [3a9340cd0d877339-35]
- ========================== Django 1.4.2 release notes ========================== [40abccd7]
- Backwards incompatible changes ============================== [f2cb124aa97ba055-5]
- Details of this issue were initially posted online as a `security advisory`_. [c21f01515684cd3c-2]
- Django's own built-in parsing of the Host header is, however, still vulnerable, as was reported to us recently. The Host header parsing in Django 1.3.3 and Django 1.4.1 -- specifically, ``django.http.HttpRequest.get_host()`` -- was incorrectly handling username/password information in the header. Thus, for example, the following Host header would be accepted by Django when running on ``validsite.com``: [8121af85b0ab026d-2]
- Host header poisoning ===================== [327c5cfb06ab025c-4]
- Other bugfixes and changes ========================== [d21cf28614bdc568]
- Some parts of Django -- independent of end-user-written applications -- make use of full URLs, including domain name, which are generated from the HTTP Host header. Some attacks against this are beyond Django's ability to control, and require the web server to be properly configured; Django's documentation has for some time contained notes advising users on such configuration. [1bc91affd57e5610-2]
- This is the second security release in the Django 1.4 series. [a9d1051b]
- To remedy this, the parsing in ``HttpRequest.get_host()`` is being modified; Host headers which contain potentially dangerous content (such as username/password pairs) now raise the exception :exc:`django.core.exceptions.SuspiciousOperation`. [933eff586b1dcda5-2]
- Using this, an attacker can cause parts of Django -- particularly the password-reset mechanism -- to generate and display arbitrary URLs to users. [7ef55d112c04218f-2]

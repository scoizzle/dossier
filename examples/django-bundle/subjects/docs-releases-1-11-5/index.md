# docs/releases/1.11.5

- Subject: docs/releases/1.11.5 (id `8c215d26-2844-487d-84be-2f7944cd4398`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 787 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- * Added POST request support to ``LogoutView``, for equivalence with the function-based ``logout()`` view (:ticket:`28513`). [3de58bbe]
- * Added compatibility for ``cx_Oracle`` 6 (:ticket:`28498`). [7ca158e0]
- * Django 1.11 inadvertently changed the sequence and trigger naming scheme on Oracle. This causes errors on INSERTs for some tables if ``'use_returning_into': False`` is in the ``OPTIONS`` part of ``DATABASES``. The pre-1.11 naming scheme is now restored. Unfortunately, it necessarily requires an update to Oracle tables created with Django 1.11.[1-4]. Use the upgrade script in :ticket:`28451` comment 8 to update sequence and trigger names to use the pre-1.11 naming scheme. [5d8ef8e5]
- * Fixed GEOS version parsing if the version has a commit hash at the end (new in GEOS 3.6.2) (:ticket:`28441`). [b60b6dde]
- * Fixed a regression in 1.11.4 where ``runserver`` crashed with non-Unicode system encodings on Python 2 + Windows (:ticket:`28487`). [56b773e1]
- * Fixed a regression in Django 1.10 where changes to a ``ManyToManyField`` weren't logged in the admin change history (:ticket:`27998`) and prevented ``ManyToManyField`` initial data in model forms from being affected by subsequent model changes (:ticket:`28543`). [035b3691]
- * Fixed a regression in ``contrib.auth``'s ``login()`` and ``logout()`` views where they ignored positional arguments (:ticket:`28550`). [a09f7fcc]
- * Fixed a regression where ``SelectDateWidget`` localized the years in the select box (:ticket:`28530`). [d3d4b9d2]
- * Fixed non-deterministic results or an ``AssertionError`` crash in some queries with multiple joins (:ticket:`26522`). [d9029237]
- * Fixed select widget rendering when option values are tuples (:ticket:`28502`). [e085a262]
- * Omitted ``pages_per_range`` from ``BrinIndex.deconstruct()`` if it's ``None`` (:ticket:`25809`). [21e1171e]
- *September 5, 2017* [d989f6eacd7f1d9c-2]
- =========================== Django 1.11.5 release notes =========================== [7a5706f3]
- Bugfixes ======== [6c84539cac9c976c-23]
- CVE-2017-12794: Possible XSS in traceback section of technical 500 debug page ============================================================================= [5d47a9fe3575851b-2]
- Django 1.11.5 fixes a security issue and several bugs in 1.11.4. [b99e76c9]
- In older versions, HTML autoescaping was disabled in a portion of the template for the technical 500 debug page. Given the right circumstances, this allowed a cross-site scripting attack. This vulnerability shouldn't affect most production sites since you shouldn't run with ``DEBUG = True`` (which makes this page accessible) in your production settings. [64dfac347d73c690-2]

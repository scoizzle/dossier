# docs/releases/1.10.2

- Subject: docs/releases/1.10.2 (id `eb99b1ac-245c-4913-aa6a-21d644832ee1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 370 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- * Allowed combining ``contrib.postgres.search.SearchQuery`` with more than one ``&`` or ``|`` operators (:ticket:`27143`). [f5047cb0]
- * Disabled system check for URL patterns beginning with a '/' when ``APPEND_SLASH=False`` (:ticket:`27238`). [2677b053]
- * Fixed a crash in MySQL database validation where ``SELECT @@sql_mode`` doesn't return a result (:ticket:`27180`). [be18e55f]
- * Fixed a crash in ``runserver`` logging during a "Broken pipe" error (:ticket:`27271`). [dbd745d3]
- * Fixed a regression where unchanged localized date/time fields were listed as changed in the admin's model history messages (:ticket:`27302`). [ee603f9d]
- * Fixed model form ``default`` fallback for ``CheckboxSelectMultiple``, ``MultiWidget``, ``FileInput``, ``SplitDateTimeWidget``, ``SelectDateWidget``, and ``SplitArrayWidget`` (:ticket:`27186`). Custom widgets affected by this issue should implement :meth:`~django.forms.Widget.value_omitted_from_data`. [624bdc34]
- *October 1, 2016* [9caac527]
- =========================== Django 1.10.2 release notes =========================== [01e50180]
- Bugfixes ======== [6c84539cac9c976c-2]
- Django 1.10.2 fixes several bugs in 1.10.1. [9463adab]

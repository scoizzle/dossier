# docs/releases/1.6.2

- Subject: docs/releases/1.6.2 (id `5cbcb5df-dbac-4f9a-a350-2ffcf32570a2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 592 tokens
- Facts shown: 15 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- * Added missing items to ``django.utils.timezone.__all__`` (:ticket:`21880`). [d1ee5745]
- * Fixed a crash when executing the :djadmin:`changepassword` command when the user object representation contained non-ASCII characters (:ticket:`21627`). [399e3dc2]
- * Fixed a field misalignment issue with ``select_related()`` and model inheritance (:ticket:`21413`). [aca8644e]
- * Fixed a regression in multiple-table inheritance ``exclude()`` queries (:ticket:`21787`). [5ae98c8d]
- * Fixed an issue where lazy objects weren't actually marked as safe when passed through :func:`~django.utils.safestring.mark_safe` and could end up being double-escaped (:ticket:`21882`). [8408ef35]
- * Fixed an issue where when ``settings.DATABASES['default']['AUTOCOMMIT'] = False``, the connection wasn't in autocommit mode but Django pretended it was. [28ac4544]
- * Fixed join promotion for negated ``AND`` conditions (:ticket:`21748`). [325539df]
- * Fixed mail encoding on Python 3.3.3+ (:ticket:`21093`). [f4c739e1]
- * Oracle database introspection now works with boolean and float fields (:ticket:`19884`). [b836001b]
- * Prevented the base geometry object of a prepared geometry to be garbage collected, which could lead to crash Django (:ticket:`21662`). [1e275cc8]
- * The :djadmin:`collectstatic` command will raise an error rather than default to using the current working directory if :setting:`STATIC_ROOT` is not set. Combined with the ``--clear`` option, the previous behavior could wipe anything below the current working directory (:ticket:`21581`). [5c522c97]
- *February 6, 2014* [a21da005]
- ========================== Django 1.6.2 release notes ========================== [d8f9c3d8]
- Additionally, Django's vendored version of six, ``django.utils.six`` has been upgraded to the latest release (1.5.2). [a311041a]
- This is Django 1.6.2, a bugfix release for Django 1.6. Django 1.6.2 fixes several bugs in 1.6.1: [020bba87]

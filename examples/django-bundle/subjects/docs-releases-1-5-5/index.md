# docs/releases/1.5.5

- Subject: docs/releases/1.5.5 (id `d64ca10f-31b4-4979-98de-78991ca905e0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 467 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a data corruption bug with ``datetime_safe.datetime.combine`` (#21256). * Fixed a Python 3 incompatibility in ``django.utils.text.unescape_entities()`` (#21185). * Fixed a couple data corruption issues with ``QuerySet`` edge cases under Oracle and MySQL (#21203, #21126). * Fixed crashes when using combinations of ``annotate()``, ``select_related()``, and ``only()`` (#16436). [4e721e1d]
- * The undocumented ``django.core.servers.basehttp.WSGIServerException`` has been removed. Use ``socket.error`` provided by the standard library instead. [f766e739]
- *October 23, 2013* [e403262854511c64-2]
- ========================== Django 1.5.5 release notes ========================== [b71f9033]
- Backwards incompatible changes ============================== [f2cb124aa97ba055-6]
- Bugfixes ======== [6c84539cac9c976c-41]
- Django 1.5.4 imposes a 4096-byte limit on passwords in order to mitigate a denial-of-service attack through submission of bogus but extremely large passwords. In Django 1.5.5, we've reverted this change and instead improved the speed of our PBKDF2 algorithm by not rehashing the key on every iteration. [4e42127d]
- Django 1.5.5 fixes a couple security-related bugs and several other bugs in the 1.5 series. [ac6593ca]
- Properly rotate CSRF token on login =================================== [1dcb219e]
- Readdressed denial-of-service via password hashers ================================================== [1e40a4bce16a0517-2]
- This behavior introduced as a security hardening measure in Django 1.5.2 did not work properly and is now fixed. [49b341d7]

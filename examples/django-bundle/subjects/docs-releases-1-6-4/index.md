# docs/releases/1.6.4

- Subject: docs/releases/1.6.4 (id `b01b5ea0-32a0-46bd-bcba-652b339ff73d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 215 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- * Added backwards compatibility support for the :mod:`django.contrib.messages` cookie format of Django 1.4 and earlier to facilitate upgrading to 1.6 from 1.4 (:ticket:`22426`). [a8012696]
- * Fixed the ``object_id`` of the ``LogEntry`` that's created after a user password change in the admin (:ticket:`22515`). [b93a4034]
- * Restored the ability to ``reverse()`` views created using :func:`functools.partial` (:ticket:`22486`). [ef2c1a2e1bc566cc-3]
- *April 28, 2014* [50e3c43f375dd59e-3]
- ========================== Django 1.6.4 release notes ========================== [4427edb3]
- Bugfixes ======== [6c84539cac9c976c-44]
- Django 1.6.4 fixes several bugs in 1.6.3. [66e1c98c]

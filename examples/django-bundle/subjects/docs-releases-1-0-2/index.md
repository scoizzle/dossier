# docs/releases/1.0.2

- Subject: docs/releases/1.0.2 (id `71e4494e-7aad-42f2-82d7-820dcd32e45f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 657 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- * A bug affecting filtering on a nullable ``DateField`` in SQLite has been resolved. [9af4c5b5]
- * A bug involving the interaction of Django's ``SafeUnicode`` class and the MySQL adapter has been resolved; ``SafeUnicode`` instances (generated, for example, by template rendering) can now be assigned to model attributes and saved to MySQL without requiring an explicit intermediate cast to ``unicode``. [3d70cd01]
- * Several updates and improvements have been made to Django's documentation. [fbe4162c]
- * The default ``__repr__`` method of Django models has been made more robust in the face of bad Unicode data coming from the ``__unicode__`` method; rather than raise an exception in such cases, ``repr()`` will now contain the string "[Bad Unicode data]" in place of the invalid Unicode. [bcda52a6]
- * Updated Hebrew and Danish translations have been added. [0fd9a1f3]
- ========================== Django 1.0.2 release notes ========================== [acef3680]
- Additionally, in the period since Django 1.0.1 was released: [afbda90e]
- Django 1.0.2 contains updated packaging scripts, and the release package contains the directories omitted from Django 1.0.1. As such, this release contains all of the fixes and improvements from Django 1.0.1; see :doc:`the Django 1.0.1 release notes </releases/1.0.1>` for details. [981bd6fe]
- Fixes and improvements in Django 1.0.2 ====================================== [1ded3896]
- The primary reason behind this release is to remedy an issue in the recently-released Django 1.0.1; the packaging scripts used for Django 1.0.1 omitted some directories from the final release package, including one directory required by ``django.contrib.gis`` and part of Django's unit-test suite. [f17a65a0]
- This is the second "bugfix" release in the Django 1.0 series, improving the stability and performance of the Django 1.0 codebase. As such, Django 1.0.2 contains no new features (and, pursuant to :doc:`our compatibility policy </misc/api-stability>`, maintains backwards compatibility with Django 1.0.0), but does contain a number of fixes and other improvements. Django 1.0.2 is a recommended upgrade for any development or deployment currently using or targeting Django 1.0. [68694c0f]
- Welcome to Django 1.0.2! [683128a5]

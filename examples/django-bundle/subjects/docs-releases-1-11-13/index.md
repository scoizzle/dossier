# docs/releases/1.11.13

- Subject: docs/releases/1.11.13 (id `18752925-5a7d-4146-a424-5d3b9ac05d98`)
- Kind: subject
- Budget: 1200 tokens
- Used: 255 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a regression in Django 1.11.12 where ``QuerySet.values()`` or ``values_list()`` after combining an annotated and unannotated queryset with ``union()``, ``difference()``, or ``intersection()`` crashed due to mismatching columns (:ticket:`29286`). [b6b0cf17]
- * Fixed a regression in Django 1.11.8 where altering a field with a unique constraint may drop and rebuild more foreign keys than necessary (:ticket:`29193`). [d164f41d]
- * Fixed crashes in ``django.contrib.admindocs`` when a view is a callable object, such as ``django.contrib.syndication.views.Feed`` (:ticket:`29296`). [bdf18590]
- *May 1, 2018* [5cac06b5]
- ============================ Django 1.11.13 release notes ============================ [fa171a87]
- Bugfixes ======== [6c84539cac9c976c-11]
- Django 1.11.13 fixes several bugs in 1.11.12. [37c3fdf4]

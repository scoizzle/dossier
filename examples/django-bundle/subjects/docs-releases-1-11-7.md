# docs/releases/1.11.7

- Subject: docs/releases/1.11.7 (id `ea31005b-f3b0-471e-82a8-b160821e13c1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 223 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed the Basque ``DATE_FORMAT`` string (:ticket:`28710`). [bd4d8be8]
- * Fixed unquoted table names in ``Subquery`` SQL when using ``OuterRef`` (:ticket:`28689`). [85e55634]
- * Made ``QuerySet.reverse()`` affect ``nulls_first`` and ``nulls_last`` (:ticket:`28722`). [c9f6dc76]
- * Prevented ``cache.get_or_set()`` from caching ``None`` if the ``default`` argument is a callable that returns ``None`` (:ticket:`28601`). [96b08527]
- *November 1, 2017* [0bd6be20]
- =========================== Django 1.11.7 release notes =========================== [39009330]
- Bugfixes ======== [6c84539cac9c976c-25]
- Django 1.11.7 fixes several bugs in 1.11.6. [251214ca]

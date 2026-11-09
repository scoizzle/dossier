# docs/releases/1.11.7

- Subject: docs/releases/1.11.7 (id `3a49392c-7c45-4f87-9159-edc65c016582`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 223 tokens
- Facts shown: 8 facts
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

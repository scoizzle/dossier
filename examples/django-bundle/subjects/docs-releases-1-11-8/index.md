# docs/releases/1.11.8

- Subject: docs/releases/1.11.8 (id `e6a03326-9347-4068-a6e4-80c1c2ff8808`)
- Kind: subject
- Budget: 1200 tokens
- Used: 447 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- * Added support for ``QuerySet.values()`` and ``values_list()`` for ``union()``, ``difference()``, and ``intersection()`` queries (:ticket:`28781`). [c4dc9cb2]
- * Fixed "Cannot change column 'x': used in a foreign key constraint" crash on MySQL with a sequence of ``AlterField`` and/or ``RenameField`` operations in a migration (:ticket:`28305`). [308bd4ce]
- * Fixed a regression in caching of a ``GenericForeignKey`` when the referenced model instance uses multi-table inheritance (:ticket:`28856`). [f6b7591f]
- * Fixed crash on SQLite and MySQL when ordering by a filtered subquery that uses ``nulls_first`` or ``nulls_last`` (:ticket:`28848`). [a36f3511]
- * Fixed incorrect index name truncation when using a namespaced ``db_table`` (:ticket:`28792`). [83b0e983]
- * Made ``QuerySet.iterator()`` use server-side cursors on PostgreSQL after ``values()`` and ``values_list()`` (:ticket:`28817`). [f1ff53cb]
- * Made query lookups for ``CICharField``, ``CIEmailField``, and ``CITextField`` use a ``citext`` cast (:ticket:`28702`). [894c6edd]
- * Reallowed, following a regression in Django 1.10, ``AuthenticationForm`` to raise the inactive user error when using ``ModelBackend`` (:ticket:`28645`). [550e14b3]
- *December 2, 2017* [c694ccfd]
- =========================== Django 1.11.8 release notes =========================== [1f58977e]
- Bugfixes ======== [6c84539cac9c976c-26]
- Django 1.11.8 fixes several bugs in 1.11.7. [1b58ac87]

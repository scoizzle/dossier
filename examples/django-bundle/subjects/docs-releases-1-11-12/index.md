# docs/releases/1.11.12

- Subject: docs/releases/1.11.12 (id `db9f1516-933d-4261-8f33-37eafc01115d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 199 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a regression in Django 1.11 where an empty choice could be initially selected for the ``SelectMultiple`` and ``CheckboxSelectMultiple`` widgets (:ticket:`29273`). [783c97cf]
- * Fixed a regression in Django 1.11.8 where combining two annotated ``values_list()`` querysets with ``union()``, ``difference()``, or ``intersection()`` crashed due to mismatching columns (:ticket:`29229`). [3bae73bc]
- *April 2, 2018* [76dec26e]
- ============================ Django 1.11.12 release notes ============================ [4ea878d8]
- Bugfixes ======== [6c84539cac9c976c-10]
- Django 1.11.12 fixes two bugs in 1.11.11. [6ca76345]

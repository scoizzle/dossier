# docs/releases/1.11.9

- Subject: docs/releases/1.11.9 (id `08e6538a-074f-4a67-b929-69760d4a0caa`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 250 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a regression in Django 1.11 that added newlines between ``MultiWidget``'s subwidgets (:ticket:`28890`). [21d00fb8]
- * Fixed a regression in caching of a ``GenericForeignKey`` when the referenced model instance uses more than one level of multi-table inheritance (:ticket:`28856`). [ca14622a]
- * Fixed incorrect class-based model index name generation for models with quoted ``db_table`` (:ticket:`28876`). [539eb58f]
- * Fixed incorrect foreign key constraint name for models with quoted ``db_table`` (:ticket:`28876`). [84bd9600]
- *January 1, 2018* [6836046f]
- =========================== Django 1.11.9 release notes =========================== [2e94b3b9]
- Bugfixes ======== [6c84539cac9c976c-27]
- Django 1.11.9 fixes several bugs in 1.11.8. [da3d8232]

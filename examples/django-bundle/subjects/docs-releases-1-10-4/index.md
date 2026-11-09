# docs/releases/1.10.4

- Subject: docs/releases/1.10.4 (id `95351035-4a14-4caa-ac29-cc9a5ad2d67a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 376 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a ``QuerySet.update()`` crash on SQLite when updating a ``DateTimeField`` with an ``F()`` expression and a ``timedelta`` (:ticket:`27544`). [8f61483a]
- * Fixed incorrect ``app_label`` / ``model_name`` arguments for ``allow_migrate()`` in ``makemigrations`` migration consistency checks (:ticket:`27461`). [43ea6a41]
- * Made ``Model.delete(keep_parents=True)`` preserve parent reverse relationships in multi-table inheritance (:ticket:`27407`). [241cdd7c]
- * Prevented ``LocaleMiddleware`` from redirecting on URLs that should return 404 when using ``prefix_default_language=False`` (:ticket:`27402`). [c3b99a93]
- * Prevented an unnecessary index from being created on an InnoDB ``ForeignKey`` when the field was added after the model was created (:ticket:`27558`). [d0957555]
- * Quoted the Oracle test user's password in queries to fix the "ORA-00922: missing or invalid option" error when the password starts with a number or special character (:ticket:`27420`). [788887b9]
- *December 1, 2016* [c03e48a4]
- =========================== Django 1.10.4 release notes =========================== [d62a18a8]
- Bugfixes ======== [6c84539cac9c976c-4]
- Django 1.10.4 fixes several bugs in 1.10.3. [0bea5a9d]

# docs/releases/1.10.5

- Subject: docs/releases/1.10.5 (id `5ec41dbc-bdba-4155-be52-64ef67400cee`)
- Kind: subject
- Budget: 1200 tokens
- Used: 243 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a crash in the debug view if ``request.user`` can't be retrieved, such as if the database is unavailable (:ticket:`27567`). [5eea6f32]
- * Fixed a regression in the ``timesince`` and ``timeuntil`` filters that caused incorrect results for dates in a leap year (:ticket:`27637`). [285dc80e]
- * Fixed a regression where ``collectstatic`` overwrote newer files in remote storages (:ticket:`27658`). [4b8e964e]
- * Fixed occasional missing plural forms in ``JavaScriptCatalog`` (:ticket:`27418`). [c3229bf9]
- *January 4, 2017* [7a46e8cb]
- =========================== Django 1.10.5 release notes =========================== [9b436b3a]
- Bugfixes ======== [6c84539cac9c976c-5]
- Django 1.10.5 fixes several bugs in 1.10.4. [506220a4]

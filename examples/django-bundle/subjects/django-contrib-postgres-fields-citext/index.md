# django/contrib/postgres/fields/citext

- Subject: django/contrib/postgres/fields/citext (id `a6b78d25-15a9-435b-b07f-c4f506432c9b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 319 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- __all__ = ["CICharField", "CIEmailField", "CITextField"] [435a8f2e]
- class CICharField(CharField): system_check_removed_details = { "msg": ( "django.contrib.postgres.fields.CICharField is removed except for support " "in historical migrations." ), "hint": ( 'Use CharField(db_collation="…") with a case-insensitive non-deterministic ' "collation instead." ), "id": "fields.E905", } [81f05afb]
- class CIEmailField(EmailField): system_check_removed_details = { "msg": ( "django.contrib.postgres.fields.CIEmailField is removed except for support " "in historical migrations." ), "hint": ( 'Use EmailField(db_collation="…") with a case-insensitive ' "non-deterministic collation instead." ), "id": "fields.E906", } [ade4b32e]
- class CITextField(TextField): system_check_removed_details = { "msg": ( "django.contrib.postgres.fields.CITextField is removed except for support " "in historical migrations." ), "hint": ( 'Use TextField(db_collation="…") with a case-insensitive non-deterministic ' "collation instead." ), "id": "fields.E907", } [498958b7]
- from django.db.models import CharField, EmailField, TextField [6125b894]

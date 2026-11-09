# django/contrib/postgres/fields/jsonb

- Subject: django/contrib/postgres/fields/jsonb (id `22ca638d-3bc6-4ec2-9253-2e0a6797c0ff`)
- Kind: subject
- Budget: 1200 tokens
- Used: 117 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- __all__ = ["JSONField"] [27dfe3814c9a1ab6]
- class JSONField(BuiltinJSONField): system_check_removed_details = { "msg": ( "django.contrib.postgres.fields.JSONField is removed except for " "support in historical migrations." ), "hint": "Use django.db.models.JSONField instead.", "id": "fields.E904", } [64bc4d42]
- from django.db.models import JSONField as BuiltinJSONField [21f0f969]

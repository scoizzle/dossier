# Fact 5dec3ccb

Store id: 559448ba-3ad5-45b9-be37-6d409bd974f5

## Text

```text
def _get_check_sql(self, model, schema_editor)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:54.1707510+00:00`

## Data

```json
{
  "end_line": 199,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 194,
  "symbol": "CheckConstraint._get_check_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":194,"selector":"L194-L199","symbol":"CheckConstraint._get_check_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint._get_check_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 199,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 194,
    "symbol": "CheckConstraint._get_check_sql"
  },
  "id": "559448ba-3ad5-45b9-be37-6d409bd974f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1707510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 194,
        "selector": "L194-L199",
        "symbol": "CheckConstraint._get_check_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "29f93a8b-66c5-40b9-a641-c65baaffc7d4",
  "subject_name": "django/db/models/constraints::CheckConstraint._get_check_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_check_sql(self, model, schema_editor)"
}
```

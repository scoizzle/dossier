# Fact cfeddd50

Store id: 3b509180-ea1b-471a-ba20-637224524575

## Text

```text
def _get_condition_sql(self, model, schema_editor)
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
- posted_at: `2026-11-09T23:44:48.7864800+00:00`

## Data

```json
{
  "end_line": 449,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 442,
  "symbol": "UniqueConstraint._get_condition_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":442,"selector":"L442-L449","symbol":"UniqueConstraint._get_condition_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint._get_condition_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 449,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 442,
    "symbol": "UniqueConstraint._get_condition_sql"
  },
  "id": "3b509180-ea1b-471a-ba20-637224524575",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7864800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 442,
        "selector": "L442-L449",
        "symbol": "UniqueConstraint._get_condition_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "3756e350-4b56-44f8-a8f2-a75cdb8993c5",
  "subject_name": "django/db/models/constraints::UniqueConstraint._get_condition_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_condition_sql(self, model, schema_editor)"
}
```

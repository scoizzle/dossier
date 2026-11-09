# Fact cfeddd50

Store id: 09e03272-a0bc-4925-b2f8-43c87047e890

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
- posted_at: `2026-11-09T23:31:54.2290050+00:00`

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
  "id": "09e03272-a0bc-4925-b2f8-43c87047e890",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2290050+00:00"
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
  "subject_id": "fe7cdf68-6979-4027-b958-60a241ff0661",
  "subject_name": "django/db/models/constraints::UniqueConstraint._get_condition_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_condition_sql(self, model, schema_editor)"
}
```

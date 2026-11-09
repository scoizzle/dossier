# Fact 95956624

Store id: 25a32443-ea97-4009-96f9-8d4259cfd856

## Text

```text
def create_sql(self, model, schema_editor)
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
- posted_at: `2026-11-09T23:31:54.1429420+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 46,
  "symbol": "BaseConstraint.create_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":46,"selector":"L46-L47","symbol":"BaseConstraint.create_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.create_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 46,
    "symbol": "BaseConstraint.create_sql"
  },
  "id": "25a32443-ea97-4009-96f9-8d4259cfd856",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1429420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 46,
        "selector": "L46-L47",
        "symbol": "BaseConstraint.create_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "6058f6ef-5a4b-4b11-9182-d8532af767d8",
  "subject_name": "django/db/models/constraints::BaseConstraint.create_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def create_sql(self, model, schema_editor)"
}
```

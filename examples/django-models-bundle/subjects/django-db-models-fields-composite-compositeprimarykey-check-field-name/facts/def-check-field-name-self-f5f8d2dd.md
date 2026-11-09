# Fact f5f8d2dd

Store id: 6f2a7e95-ea18-4ed8-bf40-b5305aaea8dc

## Text

```text
def _check_field_name(self)
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
- posted_at: `2026-11-09T23:31:57.1425980+00:00`

## Data

```json
{
  "end_line": 138,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 129,
  "symbol": "CompositePrimaryKey._check_field_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":129,"selector":"L129-L138","symbol":"CompositePrimaryKey._check_field_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey._check_field_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 138,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 129,
    "symbol": "CompositePrimaryKey._check_field_name"
  },
  "id": "6f2a7e95-ea18-4ed8-bf40-b5305aaea8dc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1425980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 129,
        "selector": "L129-L138",
        "symbol": "CompositePrimaryKey._check_field_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "be61c552-d3a8-4668-a632-e1f23105fe48",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey._check_field_name",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_field_name(self)"
}
```

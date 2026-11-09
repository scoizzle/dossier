# Fact f5f8d2dd

Store id: 70247ecc-7a6b-4120-8bad-99ad1d5e20ec

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
- posted_at: `2026-11-09T22:39:43.0166880+00:00`

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
  "id": "70247ecc-7a6b-4120-8bad-99ad1d5e20ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0166880+00:00"
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
  "subject_id": "2aaea5ab-4072-458a-a6e8-da8406d2482e",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey._check_field_name",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_field_name(self)"
}
```

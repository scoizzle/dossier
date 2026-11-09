# Fact 6ed1bd9e

Store id: 8875042a-3500-4641-966f-be61c4af6d17

## Text

```text
def cast_db_type(self, connection)
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
- posted_at: `2026-11-09T23:31:56.5525080+00:00`

## Data

```json
{
  "end_line": 1323,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1320,
  "symbol": "CharField.cast_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1320,"selector":"L1320-L1323","symbol":"CharField.cast_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.cast_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1323,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1320,
    "symbol": "CharField.cast_db_type"
  },
  "id": "8875042a-3500-4641-966f-be61c4af6d17",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5525080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1320,
        "selector": "L1320-L1323",
        "symbol": "CharField.cast_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9b822ebe-0aa5-4328-a95e-4c2e9117da1e",
  "subject_name": "django/db/models/fields/__init__::CharField.cast_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def cast_db_type(self, connection)"
}
```

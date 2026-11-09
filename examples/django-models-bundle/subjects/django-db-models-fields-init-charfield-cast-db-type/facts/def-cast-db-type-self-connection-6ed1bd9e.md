# Fact 6ed1bd9e

Store id: 349f8145-073e-4583-af53-37d93241c423

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
- posted_at: `2026-11-09T23:44:50.0646980+00:00`

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
  "id": "349f8145-073e-4583-af53-37d93241c423",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0646980+00:00"
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
  "subject_id": "dcf27109-a887-4a74-8409-915590e47f66",
  "subject_name": "django/db/models/fields/__init__::CharField.cast_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def cast_db_type(self, connection)"
}
```

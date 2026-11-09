# Fact 6ed1bd9e

Store id: 50b25fd9-53a8-4d57-8c9c-3d1da1b2e5aa

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
- posted_at: `2026-11-09T22:39:42.3799020+00:00`

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
  "id": "50b25fd9-53a8-4d57-8c9c-3d1da1b2e5aa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3799020+00:00"
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
  "subject_id": "93007d80-35dd-4f9a-88ea-7beee751c08b",
  "subject_name": "django/db/models/fields/__init__::CharField.cast_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def cast_db_type(self, connection)"
}
```

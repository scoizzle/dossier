# Fact e3ec2a1b

Store id: b95fb335-e02c-4ca2-914d-cd67a88359f5

## Text

```text
def db_tablespace(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.0252980+00:00`

## Data

```json
{
  "end_line": 970,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 968,
  "symbol": "Field.db_tablespace"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":968,"selector":"L968-L970","symbol":"Field.db_tablespace"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_tablespace](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 970,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 968,
    "symbol": "Field.db_tablespace"
  },
  "id": "b95fb335-e02c-4ca2-914d-cd67a88359f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0252980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 968,
        "selector": "L968-L970",
        "symbol": "Field.db_tablespace"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a63fbbab-c3a0-43c7-9120-68e4bb9e8669",
  "subject_name": "django/db/models/fields/__init__::Field.db_tablespace",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db_tablespace(self)"
}
```

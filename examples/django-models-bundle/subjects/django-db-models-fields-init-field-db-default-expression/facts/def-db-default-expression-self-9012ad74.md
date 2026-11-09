# Fact 9012ad74

Store id: e2bf94fa-9ca1-482c-9ddd-8564866bb72b

## Text

```text
def _db_default_expression(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.0433690+00:00`

## Data

```json
{
  "end_line": 1094,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1087,
  "symbol": "Field._db_default_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1087,"selector":"L1087-L1094","symbol":"Field._db_default_expression"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._db_default_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1094,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1087,
    "symbol": "Field._db_default_expression"
  },
  "id": "e2bf94fa-9ca1-482c-9ddd-8564866bb72b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0433690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1087,
        "selector": "L1087-L1094",
        "symbol": "Field._db_default_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "416ba15b-d8e4-4739-8e89-302b1fdd57c0",
  "subject_name": "django/db/models/fields/__init__::Field._db_default_expression",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _db_default_expression(self)"
}
```

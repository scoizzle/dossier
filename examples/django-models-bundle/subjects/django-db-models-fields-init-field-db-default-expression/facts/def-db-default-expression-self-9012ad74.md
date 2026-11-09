# Fact 9012ad74

Store id: 1ac62c81-945f-4a84-87bc-d03521090872

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
- posted_at: `2026-11-09T22:39:42.3517590+00:00`

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
  "id": "1ac62c81-945f-4a84-87bc-d03521090872",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3517590+00:00"
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
  "subject_id": "1b344b8b-cad4-44ba-9ef8-9663d602825c",
  "subject_name": "django/db/models/fields/__init__::Field._db_default_expression",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _db_default_expression(self)"
}
```

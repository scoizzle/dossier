# Fact 9012ad74

Store id: ae581c66-e09f-4ab7-bb08-0313922e3072

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
- posted_at: `2026-11-09T23:31:56.5270400+00:00`

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
  "id": "ae581c66-e09f-4ab7-bb08-0313922e3072",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5270400+00:00"
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
  "subject_id": "b7b00d7f-0857-4565-ab9b-754f352e61b9",
  "subject_name": "django/db/models/fields/__init__::Field._db_default_expression",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _db_default_expression(self)"
}
```

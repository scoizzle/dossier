# Fact afc69692

Store id: 0d9e608c-6796-4dbf-807b-c2b3d4a41bfa

## Text

```text
def db_check(self, connection)
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
- posted_at: `2026-11-09T22:39:42.3201610+00:00`

## Data

```json
{
  "end_line": 895,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 883,
  "symbol": "Field.db_check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":883,"selector":"L883-L895","symbol":"Field.db_check"}`

## Items

```json
[
  {
    "text": "Return the database column check constraint for this field, for the provided connection. Works the same way as db_type() for the case that get_internal_type() does not map to a preexisting model field.",
    "locator": {
      "line": 884
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 895,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 883,
    "symbol": "Field.db_check"
  },
  "id": "0d9e608c-6796-4dbf-807b-c2b3d4a41bfa",
  "items": [
    {
      "locator": {
        "line": 884
      },
      "text": "Return the database column check constraint for this field, for the provided connection. Works the same way as db_type() for the case that get_internal_type() does not map to a preexisting model field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3201610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 883,
        "selector": "L883-L895",
        "symbol": "Field.db_check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0b6bdfd5-39e3-4c08-a5e8-ad0500df9094",
  "subject_name": "django/db/models/fields/__init__::Field.db_check",
  "tags": [
    "entity:method"
  ],
  "text": "def db_check(self, connection)"
}
```

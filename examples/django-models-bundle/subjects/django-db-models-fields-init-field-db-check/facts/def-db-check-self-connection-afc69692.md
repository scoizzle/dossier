# Fact afc69692

Store id: e82ab986-50be-4618-932e-e3fb93a51a71

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
- posted_at: `2026-11-09T23:31:56.4743630+00:00`

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
  "id": "e82ab986-50be-4618-932e-e3fb93a51a71",
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
    "posted_at": "2026-11-09T23:31:56.4743630+00:00"
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
  "subject_id": "4c955625-6fc4-4205-8207-73d0f18182dd",
  "subject_name": "django/db/models/fields/__init__::Field.db_check",
  "tags": [
    "entity:method"
  ],
  "text": "def db_check(self, connection)"
}
```

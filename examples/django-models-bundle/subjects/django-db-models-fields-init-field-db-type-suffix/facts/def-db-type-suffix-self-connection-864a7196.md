# Fact 864a7196

Store id: f77835dc-22ae-4646-a7ee-dd126f5a66be

## Text

```text
def db_type_suffix(self, connection)
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
- posted_at: `2026-11-09T23:44:50.0222560+00:00`

## Data

```json
{
  "end_line": 957,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 956,
  "symbol": "Field.db_type_suffix"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":956,"selector":"L956-L957","symbol":"Field.db_type_suffix"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_type_suffix](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 957,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 956,
    "symbol": "Field.db_type_suffix"
  },
  "id": "f77835dc-22ae-4646-a7ee-dd126f5a66be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0222560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 956,
        "selector": "L956-L957",
        "symbol": "Field.db_type_suffix"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "23c3b5de-4364-4407-8afd-426d8dcf974e",
  "subject_name": "django/db/models/fields/__init__::Field.db_type_suffix",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type_suffix(self, connection)"
}
```

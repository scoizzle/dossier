# Fact 222b843c

Store id: 8719fc70-81f9-49fc-bc78-ecc04444b0ed

## Text

```text
def get_db_prep_save(self, value, connection)
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
- posted_at: `2026-11-09T22:39:42.3453890+00:00`

## Data

```json
{
  "end_line": 1051,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1047,
  "symbol": "Field.get_db_prep_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1047,"selector":"L1047-L1051","symbol":"Field.get_db_prep_save"}`

## Items

```json
[
  {
    "text": "Return field's value prepared for saving into a database.",
    "locator": {
      "line": 1048
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_db_prep_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1051,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1047,
    "symbol": "Field.get_db_prep_save"
  },
  "id": "8719fc70-81f9-49fc-bc78-ecc04444b0ed",
  "items": [
    {
      "locator": {
        "line": 1048
      },
      "text": "Return field's value prepared for saving into a database."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3453890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1047,
        "selector": "L1047-L1051",
        "symbol": "Field.get_db_prep_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "16a870f9-9b9f-493b-9435-bbedde8eb4ed",
  "subject_name": "django/db/models/fields/__init__::Field.get_db_prep_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_save(self, value, connection)"
}
```

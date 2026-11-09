# Fact 222b843c

Store id: ee184879-fc9b-4f38-a4fc-b1d5b3f4b993

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
- posted_at: `2026-11-09T23:31:56.5200620+00:00`

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
  "id": "ee184879-fc9b-4f38-a4fc-b1d5b3f4b993",
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
    "posted_at": "2026-11-09T23:31:56.5200620+00:00"
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
  "subject_id": "7f2dedfa-0496-4fd7-8e23-e2ebe9e18a8d",
  "subject_name": "django/db/models/fields/__init__::Field.get_db_prep_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_save(self, value, connection)"
}
```

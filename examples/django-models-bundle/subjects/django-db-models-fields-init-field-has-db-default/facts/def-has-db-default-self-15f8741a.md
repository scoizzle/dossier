# Fact 15f8741a

Store id: 77be6f0c-15a7-48eb-a83e-152d88e3851e

## Text

```text
def has_db_default(self)
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
- posted_at: `2026-11-09T23:31:56.5229620+00:00`

## Data

```json
{
  "end_line": 1059,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1057,
  "symbol": "Field.has_db_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1057,"selector":"L1057-L1059","symbol":"Field.has_db_default"}`

## Items

```json
[
  {
    "text": "Return a boolean of whether this field has a db_default value.",
    "locator": {
      "line": 1058
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.has_db_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1059,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1057,
    "symbol": "Field.has_db_default"
  },
  "id": "77be6f0c-15a7-48eb-a83e-152d88e3851e",
  "items": [
    {
      "locator": {
        "line": 1058
      },
      "text": "Return a boolean of whether this field has a db_default value."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5229620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1057,
        "selector": "L1057-L1059",
        "symbol": "Field.has_db_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b00d9d13-26ed-4f8d-a875-87706385ff6c",
  "subject_name": "django/db/models/fields/__init__::Field.has_db_default",
  "tags": [
    "entity:method"
  ],
  "text": "def has_db_default(self)"
}
```

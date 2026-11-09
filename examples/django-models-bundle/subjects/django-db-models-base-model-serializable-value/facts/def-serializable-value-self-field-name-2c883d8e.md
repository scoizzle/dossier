# Fact 2c883d8e

Store id: 94a82d60-e3f6-4e56-be87-4ba30968762a

## Text

```text
def serializable_value(self, field_name)
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
- posted_at: `2026-11-09T23:44:48.5324250+00:00`

## Data

```json
{
  "end_line": 839,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 824,
  "symbol": "Model.serializable_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":824,"selector":"L824-L839","symbol":"Model.serializable_value"}`

## Items

```json
[
  {
    "text": "Return the value of the field name for this instance. If the field is a foreign key, return the id value instead of the object. If there's no Field object with this name on the model, return the model attribute's value.",
    "locator": {
      "line": 825
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.serializable_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 839,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 824,
    "symbol": "Model.serializable_value"
  },
  "id": "94a82d60-e3f6-4e56-be87-4ba30968762a",
  "items": [
    {
      "locator": {
        "line": 825
      },
      "text": "Return the value of the field name for this instance. If the field is a foreign key, return the id value instead of the object. If there's no Field object with this name on the model, return the model attribute's value."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5324250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 824,
        "selector": "L824-L839",
        "symbol": "Model.serializable_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "6eb6ed73-8b81-4c21-9d2e-a68b6cab00e5",
  "subject_name": "django/db/models/base::Model.serializable_value",
  "tags": [
    "entity:method"
  ],
  "text": "def serializable_value(self, field_name)"
}
```

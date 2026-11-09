# Fact 2c883d8e

Store id: 51b88e40-d504-4a09-aa97-2de23db7a62a

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
- posted_at: `2026-11-09T22:39:40.3377540+00:00`

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
  "id": "51b88e40-d504-4a09-aa97-2de23db7a62a",
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
    "posted_at": "2026-11-09T22:39:40.3377540+00:00"
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
  "subject_id": "0fb469ba-1034-4616-aa1a-11d94b8b2430",
  "subject_name": "django/db/models/base::Model.serializable_value",
  "tags": [
    "entity:method"
  ],
  "text": "def serializable_value(self, field_name)"
}
```

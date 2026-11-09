# Fact a89a062b

Store id: 6a982760-1960-421b-a10c-a18ef8e8f2b5

## Text

```text
def validate_unique(self, exclude=None)
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
- posted_at: `2026-11-09T23:31:53.7545290+00:00`

## Data

```json
{
  "end_line": 1474,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1460,
  "symbol": "Model.validate_unique"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1460,"selector":"L1460-L1474","symbol":"Model.validate_unique"}`

## Items

```json
[
  {
    "text": "Check unique constraints on the model and raise ValidationError if any failed.",
    "locator": {
      "line": 1461
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.validate_unique](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1474,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1460,
    "symbol": "Model.validate_unique"
  },
  "id": "6a982760-1960-421b-a10c-a18ef8e8f2b5",
  "items": [
    {
      "locator": {
        "line": 1461
      },
      "text": "Check unique constraints on the model and raise ValidationError if any failed."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7545290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1460,
        "selector": "L1460-L1474",
        "symbol": "Model.validate_unique"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "7365c88e-89e7-414f-b4c9-652a1cb2c654",
  "subject_name": "django/db/models/base::Model.validate_unique",
  "tags": [
    "entity:method"
  ],
  "text": "def validate_unique(self, exclude=None)"
}
```

# Fact b468cb68

Store id: a74592cb-ac03-4f76-a4bf-52c0f9333733

## Text

```text
def validate_constraints(self, exclude=None)
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
- posted_at: `2026-11-09T23:31:53.7582800+00:00`

## Data

```json
{
  "end_line": 1698,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1680,
  "symbol": "Model.validate_constraints"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1680,"selector":"L1680-L1698","symbol":"Model.validate_constraints"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.validate_constraints](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1698,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1680,
    "symbol": "Model.validate_constraints"
  },
  "id": "a74592cb-ac03-4f76-a4bf-52c0f9333733",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7582800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1680,
        "selector": "L1680-L1698",
        "symbol": "Model.validate_constraints"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "1a008d57-8a99-4c9a-93f1-8a4dd4fdd234",
  "subject_name": "django/db/models/base::Model.validate_constraints",
  "tags": [
    "entity:method"
  ],
  "text": "def validate_constraints(self, exclude=None)"
}
```

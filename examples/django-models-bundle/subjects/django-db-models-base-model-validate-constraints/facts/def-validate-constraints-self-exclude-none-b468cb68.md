# Fact b468cb68

Store id: 80e8dbb0-91f4-481d-8758-9a4a76816dc0

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
- posted_at: `2026-11-09T22:39:40.3521000+00:00`

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
  "id": "80e8dbb0-91f4-481d-8758-9a4a76816dc0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3521000+00:00"
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
  "subject_id": "c3c48c67-4414-4861-9a8a-ff8ff7d8450f",
  "subject_name": "django/db/models/base::Model.validate_constraints",
  "tags": [
    "entity:method"
  ],
  "text": "def validate_constraints(self, exclude=None)"
}
```

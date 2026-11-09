# Fact 98ec6dc7

Store id: 2fddb4cf-ddff-4c58-95ba-38f92da6a592

## Text

```text
def get_constraints(self)
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
- posted_at: `2026-11-09T23:31:53.7578580+00:00`

## Data

```json
{
  "end_line": 1678,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1673,
  "symbol": "Model.get_constraints"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1673,"selector":"L1673-L1678","symbol":"Model.get_constraints"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.get_constraints](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1678,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1673,
    "symbol": "Model.get_constraints"
  },
  "id": "2fddb4cf-ddff-4c58-95ba-38f92da6a592",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7578580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1673,
        "selector": "L1673-L1678",
        "symbol": "Model.get_constraints"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "723a8c01-09e1-45c7-9508-2426e4580048",
  "subject_name": "django/db/models/base::Model.get_constraints",
  "tags": [
    "entity:method"
  ],
  "text": "def get_constraints(self)"
}
```

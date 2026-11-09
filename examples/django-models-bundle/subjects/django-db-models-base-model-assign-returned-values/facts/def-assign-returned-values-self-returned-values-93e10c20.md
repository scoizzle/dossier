# Fact 93e10c20

Store id: 4c0956b4-70d2-4b2e-a8ea-5540fed52c94

## Text

```text
def _assign_returned_values(self, returned_values, returning_fields)
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
- posted_at: `2026-11-09T22:39:40.3429910+00:00`

## Data

```json
{
  "end_line": 1268,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1261,
  "symbol": "Model._assign_returned_values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1261,"selector":"L1261-L1268","symbol":"Model._assign_returned_values"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._assign_returned_values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1268,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1261,
    "symbol": "Model._assign_returned_values"
  },
  "id": "4c0956b4-70d2-4b2e-a8ea-5540fed52c94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3429910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1261,
        "selector": "L1261-L1268",
        "symbol": "Model._assign_returned_values"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "c3f0ddc6-514c-4025-8fe8-7cb14caa9274",
  "subject_name": "django/db/models/base::Model._assign_returned_values",
  "tags": [
    "entity:method"
  ],
  "text": "def _assign_returned_values(self, returned_values, returning_fields)"
}
```

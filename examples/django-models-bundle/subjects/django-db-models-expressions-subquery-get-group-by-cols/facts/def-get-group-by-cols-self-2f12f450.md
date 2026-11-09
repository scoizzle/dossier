# Fact 2f12f450

Store id: 718645f3-b56c-4165-8ecc-ce354acfd495

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T22:39:41.7321440+00:00`

## Data

```json
{
  "end_line": 1884,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1883,
  "symbol": "Subquery.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1883,"selector":"L1883-L1884","symbol":"Subquery.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1884,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1883,
    "symbol": "Subquery.get_group_by_cols"
  },
  "id": "718645f3-b56c-4165-8ecc-ce354acfd495",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7321440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1883,
        "selector": "L1883-L1884",
        "symbol": "Subquery.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c32dbb9f-beec-4d3d-9962-7e25e779a326",
  "subject_name": "django/db/models/expressions::Subquery.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

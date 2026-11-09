# Fact 63a86e39

Store id: 2def274d-eae1-48d0-abe0-3df2c5602c93

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
- posted_at: `2026-11-09T22:39:41.6618670+00:00`

## Data

```json
{
  "end_line": 1513,
  "entity_kind": "method",
  "parent": "ExpressionList",
  "start_line": 1509,
  "symbol": "ExpressionList.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1509,"selector":"L1509-L1513","symbol":"ExpressionList.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionList.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1513,
    "entity_kind": "method",
    "parent": "ExpressionList",
    "start_line": 1509,
    "symbol": "ExpressionList.get_group_by_cols"
  },
  "id": "2def274d-eae1-48d0-abe0-3df2c5602c93",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6618670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1509,
        "selector": "L1509-L1513",
        "symbol": "ExpressionList.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "17ffd214-0a87-43e0-81f7-3f0d6a443473",
  "subject_name": "django/db/models/expressions::ExpressionList.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

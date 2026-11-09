# Fact 63a86e39

Store id: 5b983a4c-6e8e-4d5c-abe3-a44734bde48a

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
- posted_at: `2026-11-09T23:31:55.9287760+00:00`

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
  "id": "5b983a4c-6e8e-4d5c-abe3-a44734bde48a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9287760+00:00"
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
  "subject_id": "74bd88b6-0307-4d56-a903-cbe9b64d4e92",
  "subject_name": "django/db/models/expressions::ExpressionList.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

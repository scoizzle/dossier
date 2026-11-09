# Fact 426212cb

Store id: decc1094-7815-49e2-bd28-67d633997241

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
- posted_at: `2026-11-09T23:44:49.5973020+00:00`

## Data

```json
{
  "end_line": 1571,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1564,
  "symbol": "ExpressionWrapper.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1564,"selector":"L1564-L1571","symbol":"ExpressionWrapper.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1571,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1564,
    "symbol": "ExpressionWrapper.get_group_by_cols"
  },
  "id": "decc1094-7815-49e2-bd28-67d633997241",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5973020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1564,
        "selector": "L1564-L1571",
        "symbol": "ExpressionWrapper.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6f375443-edaa-43ff-bb2b-bb8579c0c5d9",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

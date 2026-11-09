# Fact 426212cb

Store id: ebfc319f-afc1-4ec4-a96a-b37e8f6113ee

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
- posted_at: `2026-11-09T23:31:55.9361360+00:00`

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
  "id": "ebfc319f-afc1-4ec4-a96a-b37e8f6113ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9361360+00:00"
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
  "subject_id": "3d05ba36-d7dd-4076-a36f-1d1485d8cac4",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

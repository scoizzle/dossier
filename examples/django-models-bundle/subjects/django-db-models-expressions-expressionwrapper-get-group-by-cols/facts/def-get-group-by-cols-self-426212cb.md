# Fact 426212cb

Store id: 08d3dfbf-7a22-4836-8285-2b14589e70b6

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
- posted_at: `2026-11-09T22:39:41.6729240+00:00`

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
  "id": "08d3dfbf-7a22-4836-8285-2b14589e70b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6729240+00:00"
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
  "subject_id": "b00a931d-f316-47c7-be60-d60c8aed60b9",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

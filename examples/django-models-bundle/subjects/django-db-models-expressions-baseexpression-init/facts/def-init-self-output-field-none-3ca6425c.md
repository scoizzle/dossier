# Fact 3ca6425c

Store id: 6f5271ea-1891-44f4-8e35-6e800df2f729

## Text

```text
def __init__(self, output_field=None)
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
- posted_at: `2026-11-09T23:44:49.2655300+00:00`

## Data

```json
{
  "end_line": 195,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 193,
  "symbol": "BaseExpression.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":193,"selector":"L193-L195","symbol":"BaseExpression.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 195,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 193,
    "symbol": "BaseExpression.__init__"
  },
  "id": "6f5271ea-1891-44f4-8e35-6e800df2f729",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2655300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 193,
        "selector": "L193-L195",
        "symbol": "BaseExpression.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "650a3bf8-8554-4668-867d-d437502d4f1d",
  "subject_name": "django/db/models/expressions::BaseExpression.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, output_field=None)"
}
```

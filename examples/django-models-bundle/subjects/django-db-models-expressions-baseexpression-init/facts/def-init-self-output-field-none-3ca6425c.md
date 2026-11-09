# Fact 3ca6425c

Store id: fc8da280-a592-418e-8e6f-193327219d69

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
- posted_at: `2026-11-09T23:31:55.7576870+00:00`

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
  "id": "fc8da280-a592-418e-8e6f-193327219d69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7576870+00:00"
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
  "subject_id": "982dc508-2d04-4f97-9e31-01240d994b49",
  "subject_name": "django/db/models/expressions::BaseExpression.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, output_field=None)"
}
```

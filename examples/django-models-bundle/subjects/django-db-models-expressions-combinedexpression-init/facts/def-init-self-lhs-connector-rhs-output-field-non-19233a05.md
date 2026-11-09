# Fact 19233a05

Store id: b789c104-45f8-4ef8-8d9f-a523edf9edd3

## Text

```text
def __init__(self, lhs, connector, rhs, output_field=None)
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
- posted_at: `2026-11-09T23:31:55.8098680+00:00`

## Data

```json
{
  "end_line": 733,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 729,
  "symbol": "CombinedExpression.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":729,"selector":"L729-L733","symbol":"CombinedExpression.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 733,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 729,
    "symbol": "CombinedExpression.__init__"
  },
  "id": "b789c104-45f8-4ef8-8d9f-a523edf9edd3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8098680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 729,
        "selector": "L729-L733",
        "symbol": "CombinedExpression.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b80065aa-559f-4dbc-8a6d-6dab1ea2ab05",
  "subject_name": "django/db/models/expressions::CombinedExpression.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lhs, connector, rhs, output_field=None)"
}
```

# Fact 512309f0

Store id: 91b403b7-edde-4ec8-ac9b-5ce81d181c7f

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:49.4344930+00:00`

## Data

```json
{
  "end_line": 736,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 735,
  "symbol": "CombinedExpression.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":735,"selector":"L735-L736","symbol":"CombinedExpression.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 736,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 735,
    "symbol": "CombinedExpression.__repr__"
  },
  "id": "91b403b7-edde-4ec8-ac9b-5ce81d181c7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4344930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 735,
        "selector": "L735-L736",
        "symbol": "CombinedExpression.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "31134b0a-896d-4fa9-b4f4-2cae91ed7200",
  "subject_name": "django/db/models/expressions::CombinedExpression.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```

# Fact 02ce5f4b

Store id: 70176b6a-2e3e-4916-9fd5-340f7393d131

## Text

```text
def __invert__(self)
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
- posted_at: `2026-11-09T23:31:55.9411270+00:00`

## Data

```json
{
  "end_line": 1591,
  "entity_kind": "method",
  "parent": "NegatedExpression",
  "start_line": 1590,
  "symbol": "NegatedExpression.__invert__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1590,"selector":"L1590-L1591","symbol":"NegatedExpression.__invert__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression.__invert__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1591,
    "entity_kind": "method",
    "parent": "NegatedExpression",
    "start_line": 1590,
    "symbol": "NegatedExpression.__invert__"
  },
  "id": "70176b6a-2e3e-4916-9fd5-340f7393d131",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9411270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1590,
        "selector": "L1590-L1591",
        "symbol": "NegatedExpression.__invert__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0a9af661-ecde-4702-af5e-19322abcbaa1",
  "subject_name": "django/db/models/expressions::NegatedExpression.__invert__",
  "tags": [
    "entity:method"
  ],
  "text": "def __invert__(self)"
}
```

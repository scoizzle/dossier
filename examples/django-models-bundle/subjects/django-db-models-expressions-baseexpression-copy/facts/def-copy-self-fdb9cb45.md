# Fact fdb9cb45

Store id: e16ff853-3370-40b5-8580-d47c90869099

## Text

```text
def copy(self)
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
- posted_at: `2026-11-09T23:44:49.3566040+00:00`

## Data

```json
{
  "end_line": 444,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 443,
  "symbol": "BaseExpression.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":443,"selector":"L443-L444","symbol":"BaseExpression.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 444,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 443,
    "symbol": "BaseExpression.copy"
  },
  "id": "e16ff853-3370-40b5-8580-d47c90869099",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3566040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 443,
        "selector": "L443-L444",
        "symbol": "BaseExpression.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8c700f90-f612-40df-9c03-310b03e3264d",
  "subject_name": "django/db/models/expressions::BaseExpression.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```

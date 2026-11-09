# Fact 06744e06

Store id: 77460fe9-02d7-4a93-b85b-8a819a9077c6

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:31:55.7616960+00:00`

## Data

```json
{
  "end_line": 210,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 209,
  "symbol": "BaseExpression.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":209,"selector":"L209-L210","symbol":"BaseExpression.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 210,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 209,
    "symbol": "BaseExpression.get_source_expressions"
  },
  "id": "77460fe9-02d7-4a93-b85b-8a819a9077c6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7616960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 209,
        "selector": "L209-L210",
        "symbol": "BaseExpression.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1b9ceeb4-0a2a-4fc7-893e-d21ac15d89cb",
  "subject_name": "django/db/models/expressions::BaseExpression.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

# Fact a106f5c1

Store id: f5bdf5bc-cd86-4a13-a646-2bbfd2186f54

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:31:55.7629070+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 212,
  "symbol": "BaseExpression.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":212,"selector":"L212-L213","symbol":"BaseExpression.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 212,
    "symbol": "BaseExpression.set_source_expressions"
  },
  "id": "f5bdf5bc-cd86-4a13-a646-2bbfd2186f54",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7629070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 212,
        "selector": "L212-L213",
        "symbol": "BaseExpression.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "fc258f7a-e063-4d96-8d21-da32f2a20dfa",
  "subject_name": "django/db/models/expressions::BaseExpression.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

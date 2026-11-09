# Fact c9affbfa

Store id: bb716e1b-274e-458f-837e-870f762f2262

## Text

```text
def contains_column_references(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.3186460+00:00`

## Data

```json
{
  "end_line": 270,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 265,
  "symbol": "BaseExpression.contains_column_references"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":265,"selector":"L265-L270","symbol":"BaseExpression.contains_column_references"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.contains_column_references](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 270,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 265,
    "symbol": "BaseExpression.contains_column_references"
  },
  "id": "bb716e1b-274e-458f-837e-870f762f2262",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3186460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 265,
        "selector": "L265-L270",
        "symbol": "BaseExpression.contains_column_references"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d9edb332-c879-4fc3-a023-c94264b35f82",
  "subject_name": "django/db/models/expressions::BaseExpression.contains_column_references",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_column_references(self)"
}
```

# Fact 102758c0

Store id: b4013f0c-5e4b-409f-91c1-ec674c93cb0b

## Text

```text
def _parse_expressions(self, *expressions)
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
- posted_at: `2026-11-09T23:31:55.7640140+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 215,
  "symbol": "BaseExpression._parse_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":215,"selector":"L215-L223","symbol":"BaseExpression._parse_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression._parse_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 215,
    "symbol": "BaseExpression._parse_expressions"
  },
  "id": "b4013f0c-5e4b-409f-91c1-ec674c93cb0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7640140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 215,
        "selector": "L215-L223",
        "symbol": "BaseExpression._parse_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0de24df0-a9d0-4f47-8083-3083404da11b",
  "subject_name": "django/db/models/expressions::BaseExpression._parse_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def _parse_expressions(self, *expressions)"
}
```

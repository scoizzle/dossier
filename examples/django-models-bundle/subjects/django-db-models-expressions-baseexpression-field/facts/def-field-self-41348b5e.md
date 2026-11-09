# Fact 41348b5e

Store id: db22e3e6-4a1e-4005-8f97-7fc6281e9664

## Text

```text
def field(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.3296730+00:00`

## Data

```json
{
  "end_line": 323,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 321,
  "symbol": "BaseExpression.field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":321,"selector":"L321-L323","symbol":"BaseExpression.field"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 323,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 321,
    "symbol": "BaseExpression.field"
  },
  "id": "db22e3e6-4a1e-4005-8f97-7fc6281e9664",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3296730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 321,
        "selector": "L321-L323",
        "symbol": "BaseExpression.field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2d0892e3-c0da-40ce-ae47-815a62db326e",
  "subject_name": "django/db/models/expressions::BaseExpression.field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def field(self)"
}
```

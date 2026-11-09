# Fact 25ec0091

Store id: aa6986ef-67d6-4880-8208-3a32e436ff5f

## Text

```text
def get_transform(self, name)
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
- posted_at: `2026-11-09T23:44:49.3448490+00:00`

## Data

```json
{
  "end_line": 407,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 406,
  "symbol": "BaseExpression.get_transform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":406,"selector":"L406-L407","symbol":"BaseExpression.get_transform"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_transform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 407,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 406,
    "symbol": "BaseExpression.get_transform"
  },
  "id": "aa6986ef-67d6-4880-8208-3a32e436ff5f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3448490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 406,
        "selector": "L406-L407",
        "symbol": "BaseExpression.get_transform"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6b8d9780-f55c-4cc4-8a99-ab2a508729f1",
  "subject_name": "django/db/models/expressions::BaseExpression.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, name)"
}
```

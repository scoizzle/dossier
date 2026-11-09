# Fact 25ec0091

Store id: 732d9dcd-9612-4943-b8aa-0cd25f8f7d26

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
- posted_at: `2026-11-09T22:39:41.5224950+00:00`

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
  "id": "732d9dcd-9612-4943-b8aa-0cd25f8f7d26",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5224950+00:00"
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
  "subject_id": "47f31418-03b3-4ff8-99dc-963f6b605c6b",
  "subject_name": "django/db/models/expressions::BaseExpression.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, name)"
}
```

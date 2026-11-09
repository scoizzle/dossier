# Fact 1eb0b1a9

Store id: 3b21297b-9b63-4855-b23a-06167bbeb064

## Text

```text
def get_refs(self)
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
- posted_at: `2026-11-09T23:31:55.7881690+00:00`

## Data

```json
{
  "end_line": 441,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 435,
  "symbol": "BaseExpression.get_refs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":435,"selector":"L435-L441","symbol":"BaseExpression.get_refs"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_refs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 441,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 435,
    "symbol": "BaseExpression.get_refs"
  },
  "id": "3b21297b-9b63-4855-b23a-06167bbeb064",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7881690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 435,
        "selector": "L435-L441",
        "symbol": "BaseExpression.get_refs"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0c42e82e-78a8-48a6-b7dd-b8b05122b56a",
  "subject_name": "django/db/models/expressions::BaseExpression.get_refs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_refs(self)"
}
```

# Fact 1eb0b1a9

Store id: 4139fda9-d810-44fb-91ba-b1956c501b0c

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
- posted_at: `2026-11-09T23:44:49.3519980+00:00`

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
  "id": "4139fda9-d810-44fb-91ba-b1956c501b0c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3519980+00:00"
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
  "subject_id": "d88580ba-114e-4c95-abc9-5a3fbb050d1a",
  "subject_name": "django/db/models/expressions::BaseExpression.get_refs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_refs(self)"
}
```

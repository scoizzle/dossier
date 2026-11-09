# Fact d9aad98f

Store id: 05826f9e-1213-4903-945f-b09d5d859017

## Text

```text
def asc(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:49.3752550+00:00`

## Data

```json
{
  "end_line": 473,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 472,
  "symbol": "BaseExpression.asc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":472,"selector":"L472-L473","symbol":"BaseExpression.asc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.asc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 473,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 472,
    "symbol": "BaseExpression.asc"
  },
  "id": "05826f9e-1213-4903-945f-b09d5d859017",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3752550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 472,
        "selector": "L472-L473",
        "symbol": "BaseExpression.asc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5688f54c-5d56-4994-b83d-71d97eb0cce8",
  "subject_name": "django/db/models/expressions::BaseExpression.asc",
  "tags": [
    "entity:method"
  ],
  "text": "def asc(self, **kwargs)"
}
```

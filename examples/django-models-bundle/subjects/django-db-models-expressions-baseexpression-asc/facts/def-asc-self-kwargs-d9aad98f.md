# Fact d9aad98f

Store id: ca53142e-8007-465c-9d16-32f38a5e26e5

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
- posted_at: `2026-11-09T22:39:41.5300250+00:00`

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
  "id": "ca53142e-8007-465c-9d16-32f38a5e26e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5300250+00:00"
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
  "subject_id": "fd07e7cc-9d3f-4554-b5b7-107edacbf7cb",
  "subject_name": "django/db/models/expressions::BaseExpression.asc",
  "tags": [
    "entity:method"
  ],
  "text": "def asc(self, **kwargs)"
}
```

# Fact 1e9d1e94

Store id: b2322f18-cef3-415d-887d-3fa75161f18b

## Text

```text
def register_wrappers(cls, *wrapper_classes)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.8172500+00:00`

## Data

```json
{
  "end_line": 326,
  "entity_kind": "class_method",
  "parent": "IndexExpression",
  "start_line": 324,
  "symbol": "IndexExpression.register_wrappers"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":324,"selector":"L324-L326","symbol":"IndexExpression.register_wrappers"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::IndexExpression.register_wrappers](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 326,
    "entity_kind": "class_method",
    "parent": "IndexExpression",
    "start_line": 324,
    "symbol": "IndexExpression.register_wrappers"
  },
  "id": "b2322f18-cef3-415d-887d-3fa75161f18b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.8172500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 324,
        "selector": "L324-L326",
        "symbol": "IndexExpression.register_wrappers"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "a62a2a21-f043-46c2-b103-1349278ecd1b",
  "subject_name": "django/db/models/indexes::IndexExpression.register_wrappers",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def register_wrappers(cls, *wrapper_classes)"
}
```

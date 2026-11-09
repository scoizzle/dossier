# Fact 9ae961f5

Store id: 0254359b-d4ed-4b0d-8b71-31968a9c60c3

## Text

```text
def _check_indexes(cls, databases)
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
- posted_at: `2026-11-09T23:44:48.5520980+00:00`

## Data

```json
{
  "end_line": 2204,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2195,
  "symbol": "Model._check_indexes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2195,"selector":"L2195-L2204","symbol":"Model._check_indexes"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_indexes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2204,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2195,
    "symbol": "Model._check_indexes"
  },
  "id": "0254359b-d4ed-4b0d-8b71-31968a9c60c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5520980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2195,
        "selector": "L2195-L2204",
        "symbol": "Model._check_indexes"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "d4d8eed7-e4f1-4feb-ab7a-32f59428fe69",
  "subject_name": "django/db/models/base::Model._check_indexes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_indexes(cls, databases)"
}
```

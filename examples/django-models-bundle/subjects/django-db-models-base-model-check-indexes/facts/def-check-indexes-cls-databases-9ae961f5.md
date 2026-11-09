# Fact 9ae961f5

Store id: c18c1a20-c240-46f8-9e01-c48d8a403d38

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
- posted_at: `2026-11-09T22:39:40.3626350+00:00`

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
  "id": "c18c1a20-c240-46f8-9e01-c48d8a403d38",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3626350+00:00"
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
  "subject_id": "8638b609-a077-4938-9664-8eac08c25645",
  "subject_name": "django/db/models/base::Model._check_indexes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_indexes(cls, databases)"
}
```

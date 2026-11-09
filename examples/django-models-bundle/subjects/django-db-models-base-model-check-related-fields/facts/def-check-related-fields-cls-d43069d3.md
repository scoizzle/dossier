# Fact d43069d3

Store id: f4aab2bd-1f53-41dd-b6df-d1484a013740

## Text

```text
def _check_related_fields(cls)
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
- posted_at: `2026-11-09T22:39:40.3668640+00:00`

## Data

```json
{
  "end_line": 2495,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2474,
  "symbol": "Model._check_related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2474,"selector":"L2474-L2495","symbol":"Model._check_related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2495,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2474,
    "symbol": "Model._check_related_fields"
  },
  "id": "f4aab2bd-1f53-41dd-b6df-d1484a013740",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3668640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2474,
        "selector": "L2474-L2495",
        "symbol": "Model._check_related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "f68fcfc6-e9e5-45eb-9b2f-4379f8243f14",
  "subject_name": "django/db/models/base::Model._check_related_fields",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_related_fields(cls)"
}
```

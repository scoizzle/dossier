# Fact 9ae961f5

Store id: 11c45636-9ef2-4ff4-9041-b3cde31708eb

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
- posted_at: `2026-11-09T23:31:53.7673530+00:00`

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
  "id": "11c45636-9ef2-4ff4-9041-b3cde31708eb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7673530+00:00"
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
  "subject_id": "3ff667d6-f6b3-46f2-a1db-c36c849c3c2a",
  "subject_name": "django/db/models/base::Model._check_indexes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_indexes(cls, databases)"
}
```

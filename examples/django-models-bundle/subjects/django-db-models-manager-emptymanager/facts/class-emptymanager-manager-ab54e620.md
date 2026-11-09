# Fact ab54e620

Store id: 56124195-3937-4acd-8aee-023a132b2d04

## Text

```text
class EmptyManager(Manager)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.7254200+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "class",
  "parent": "manager",
  "start_line": 207,
  "symbol": "EmptyManager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":207,"selector":"L207-L213","symbol":"EmptyManager"}`

## Referenced by

None.

## Subject

[django/db/models/manager::EmptyManager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "class",
    "parent": "manager",
    "start_line": 207,
    "symbol": "EmptyManager"
  },
  "id": "56124195-3937-4acd-8aee-023a132b2d04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7254200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 207,
        "selector": "L207-L213",
        "symbol": "EmptyManager"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "bdecd72c-d0ee-4845-a253-b31ffff78b1c",
  "subject_name": "django/db/models/manager::EmptyManager",
  "tags": [
    "entity:class"
  ],
  "text": "class EmptyManager(Manager)"
}
```

# Fact 637c877d

Store id: ab405e74-3eb4-413f-8d64-3e0725b3255a

## Text

```text
def get_queryset(self)
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
- posted_at: `2026-11-09T23:44:55.3272110+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "method",
  "parent": "EmptyManager",
  "start_line": 212,
  "symbol": "EmptyManager.get_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":212,"selector":"L212-L213","symbol":"EmptyManager.get_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/manager::EmptyManager.get_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "method",
    "parent": "EmptyManager",
    "start_line": 212,
    "symbol": "EmptyManager.get_queryset"
  },
  "id": "ab405e74-3eb4-413f-8d64-3e0725b3255a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3272110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 212,
        "selector": "L212-L213",
        "symbol": "EmptyManager.get_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "e50f4ec7-f46c-476a-8393-920436d2c82a",
  "subject_name": "django/db/models/manager::EmptyManager.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self)"
}
```

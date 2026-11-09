# Fact 637c877d

Store id: 3e304ca7-8e8f-4e46-ac2c-0aa0dcc137a6

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
- posted_at: `2026-11-09T23:32:03.7316590+00:00`

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
  "id": "3e304ca7-8e8f-4e46-ac2c-0aa0dcc137a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7316590+00:00"
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
  "subject_id": "81c36474-3794-44d2-977b-0a5018195f72",
  "subject_name": "django/db/models/manager::EmptyManager.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self)"
}
```

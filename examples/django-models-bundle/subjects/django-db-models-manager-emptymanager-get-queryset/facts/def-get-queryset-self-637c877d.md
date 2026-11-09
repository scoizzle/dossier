# Fact 637c877d

Store id: 263fb293-456c-4b3a-b542-93fdbba7eb2a

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
- posted_at: `2026-11-09T22:39:48.5556330+00:00`

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
  "id": "263fb293-456c-4b3a-b542-93fdbba7eb2a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5556330+00:00"
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
  "subject_id": "d2b51427-f872-47f2-8f78-707bc35aadef",
  "subject_name": "django/db/models/manager::EmptyManager.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self)"
}
```

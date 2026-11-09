# Fact 755d916d

Store id: ee7589ba-8f9a-4a83-ade8-a04626aee3d9

## Text

```text
class Manager(BaseManager.from_queryset(QuerySet))
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
- posted_at: `2026-11-09T23:44:55.3111740+00:00`

## Data

```json
{
  "end_line": 177,
  "entity_kind": "class",
  "parent": "manager",
  "start_line": 176,
  "symbol": "Manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"selector":"L176-L177","symbol":"Manager"}`

## Referenced by

None.

## Subject

[django/db/models/manager::Manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 177,
    "entity_kind": "class",
    "parent": "manager",
    "start_line": 176,
    "symbol": "Manager"
  },
  "id": "ee7589ba-8f9a-4a83-ade8-a04626aee3d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3111740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 176,
        "selector": "L176-L177",
        "symbol": "Manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "d7fe8e4c-e577-4ffe-b97f-a2b18b04534f",
  "subject_name": "django/db/models/manager::Manager",
  "tags": [
    "entity:class"
  ],
  "text": "class Manager(BaseManager.from_queryset(QuerySet))"
}
```

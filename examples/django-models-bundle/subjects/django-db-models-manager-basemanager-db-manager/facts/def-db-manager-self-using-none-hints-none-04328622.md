# Fact 04328622

Store id: a44d4403-db12-4654-9ca2-27611aea134b

## Text

```text
def db_manager(self, using=None, hints=None)
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
- posted_at: `2026-11-09T23:32:03.6957110+00:00`

## Data

```json
{
  "end_line": 140,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 136,
  "symbol": "BaseManager.db_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":136,"selector":"L136-L140","symbol":"BaseManager.db_manager"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.db_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 140,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 136,
    "symbol": "BaseManager.db_manager"
  },
  "id": "a44d4403-db12-4654-9ca2-27611aea134b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6957110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 136,
        "selector": "L136-L140",
        "symbol": "BaseManager.db_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "04a57d0c-ed6b-47fa-a376-cb4d953cfb2f",
  "subject_name": "django/db/models/manager::BaseManager.db_manager",
  "tags": [
    "entity:method"
  ],
  "text": "def db_manager(self, using=None, hints=None)"
}
```

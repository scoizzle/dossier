# Fact cd28f77d

Store id: 9db8c66d-beeb-4dd9-a15a-79d10c4e5b91

## Text

```text
class BaseManager
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
- posted_at: `2026-11-09T23:32:03.6337410+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "class",
  "parent": "manager",
  "start_line": 10,
  "symbol": "BaseManager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"selector":"L10-L173","symbol":"BaseManager"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "class",
    "parent": "manager",
    "start_line": 10,
    "symbol": "BaseManager"
  },
  "id": "9db8c66d-beeb-4dd9-a15a-79d10c4e5b91",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6337410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 10,
        "selector": "L10-L173",
        "symbol": "BaseManager"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "eec8cf94-8f7e-4c53-a088-afc3b719fa93",
  "subject_name": "django/db/models/manager::BaseManager",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseManager"
}
```

# Fact 344dc4da

Store id: 747812f9-4be1-4943-a6ee-41a64849c196

## Text

```text
class Model(AltersData, metaclass=ModelBase)
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
- posted_at: `2026-11-09T22:39:40.3310430+00:00`

## Data

```json
{
  "end_line": 2522,
  "entity_kind": "class",
  "parent": "base",
  "start_line": 501,
  "symbol": "Model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":501,"selector":"L501-L2522","symbol":"Model"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2522,
    "entity_kind": "class",
    "parent": "base",
    "start_line": 501,
    "symbol": "Model"
  },
  "id": "747812f9-4be1-4943-a6ee-41a64849c196",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3310430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 501,
        "selector": "L501-L2522",
        "symbol": "Model"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "10f9de65-89a8-43be-a914-51ae4cf587ad",
  "subject_name": "django/db/models/base::Model",
  "tags": [
    "entity:class"
  ],
  "text": "class Model(AltersData, metaclass=ModelBase)"
}
```

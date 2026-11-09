# Fact 4c5ab4c7

Store id: 68538271-8c0a-4c8c-b553-583bd2c744d5

## Text

```text
class ModelBase(type)
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
- posted_at: `2026-11-09T23:31:53.7258620+00:00`

## Data

```json
{
  "end_line": 459,
  "entity_kind": "class",
  "parent": "base",
  "start_line": 95,
  "symbol": "ModelBase"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":95,"selector":"L95-L459","symbol":"ModelBase"}`

## Items

```json
[
  {
    "text": "Metaclass for all models.",
    "locator": {
      "line": 96
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::ModelBase](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 459,
    "entity_kind": "class",
    "parent": "base",
    "start_line": 95,
    "symbol": "ModelBase"
  },
  "id": "68538271-8c0a-4c8c-b553-583bd2c744d5",
  "items": [
    {
      "locator": {
        "line": 96
      },
      "text": "Metaclass for all models."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7258620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 95,
        "selector": "L95-L459",
        "symbol": "ModelBase"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "9a92cbbd-4c60-42e8-bfa5-d2a8714c789b",
  "subject_name": "django/db/models/base::ModelBase",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelBase(type)"
}
```

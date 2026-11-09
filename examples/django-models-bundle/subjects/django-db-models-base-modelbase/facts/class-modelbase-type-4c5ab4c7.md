# Fact 4c5ab4c7

Store id: 5bd905e3-37f9-4a9d-8c94-5b3b855fa8a9

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
- posted_at: `2026-11-09T22:39:40.3247890+00:00`

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
  "id": "5bd905e3-37f9-4a9d-8c94-5b3b855fa8a9",
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
    "posted_at": "2026-11-09T22:39:40.3247890+00:00"
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
  "subject_id": "6a5f30df-9892-47b2-9b4e-f3ec1c1fbaf3",
  "subject_name": "django/db/models/base::ModelBase",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelBase(type)"
}
```

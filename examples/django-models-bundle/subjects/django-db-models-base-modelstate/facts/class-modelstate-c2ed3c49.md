# Fact c2ed3c49

Store id: 3f9b6760-5880-4fe7-9910-f7b4efebf73a

## Text

```text
class ModelState
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
- posted_at: `2026-11-09T23:44:48.5240390+00:00`

## Data

```json
{
  "end_line": 498,
  "entity_kind": "class",
  "parent": "base",
  "start_line": 478,
  "symbol": "ModelState"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":478,"selector":"L478-L498","symbol":"ModelState"}`

## Items

```json
[
  {
    "text": "Store model instance state.",
    "locator": {
      "line": 479
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::ModelState](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 498,
    "entity_kind": "class",
    "parent": "base",
    "start_line": 478,
    "symbol": "ModelState"
  },
  "id": "3f9b6760-5880-4fe7-9910-f7b4efebf73a",
  "items": [
    {
      "locator": {
        "line": 479
      },
      "text": "Store model instance state."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5240390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 478,
        "selector": "L478-L498",
        "symbol": "ModelState"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "f06cfd3e-1ef3-4573-b6c4-327a9e2eac72",
  "subject_name": "django/db/models/base::ModelState",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelState"
}
```

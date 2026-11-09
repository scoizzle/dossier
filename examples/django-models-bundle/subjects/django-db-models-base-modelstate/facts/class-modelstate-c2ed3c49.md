# Fact c2ed3c49

Store id: f58732c1-acc9-4ef4-a8e1-4cccea499462

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
- posted_at: `2026-11-09T22:39:40.3298260+00:00`

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
  "id": "f58732c1-acc9-4ef4-a8e1-4cccea499462",
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
    "posted_at": "2026-11-09T22:39:40.3298260+00:00"
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
  "subject_id": "728299c0-c7be-4b0e-9957-ce27dbbc6ee0",
  "subject_name": "django/db/models/base::ModelState",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelState"
}
```

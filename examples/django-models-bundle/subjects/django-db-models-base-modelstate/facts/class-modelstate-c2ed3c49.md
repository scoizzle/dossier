# Fact c2ed3c49

Store id: 6742c81c-8051-4efa-81d5-267fc482c405

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
- posted_at: `2026-11-09T23:31:53.7298830+00:00`

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
  "id": "6742c81c-8051-4efa-81d5-267fc482c405",
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
    "posted_at": "2026-11-09T23:31:53.7298830+00:00"
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
  "subject_id": "8caa973c-6176-4fb4-8250-833fbfe487e9",
  "subject_name": "django/db/models/base::ModelState",
  "tags": [
    "entity:class"
  ],
  "text": "class ModelState"
}
```

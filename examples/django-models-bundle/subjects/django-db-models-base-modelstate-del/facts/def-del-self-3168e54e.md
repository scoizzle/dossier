# Fact 3168e54e

Store id: f6639c3a-c2c4-4445-aea0-433116d9798d

## Text

```text
def __del__(self)
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
- posted_at: `2026-11-09T23:44:48.5251140+00:00`

## Data

```json
{
  "end_line": 498,
  "entity_kind": "method",
  "parent": "ModelState",
  "start_line": 497,
  "symbol": "ModelState.__del__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":497,"selector":"L497-L498","symbol":"ModelState.__del__"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelState.__del__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 498,
    "entity_kind": "method",
    "parent": "ModelState",
    "start_line": 497,
    "symbol": "ModelState.__del__"
  },
  "id": "f6639c3a-c2c4-4445-aea0-433116d9798d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5251140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 497,
        "selector": "L497-L498",
        "symbol": "ModelState.__del__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "985e754f-8ff9-416f-acb8-3fbee272bfa0",
  "subject_name": "django/db/models/base::ModelState.__del__",
  "tags": [
    "entity:method"
  ],
  "text": "def __del__(self)"
}
```

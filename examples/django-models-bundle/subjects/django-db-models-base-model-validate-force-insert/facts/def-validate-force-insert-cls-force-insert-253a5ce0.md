# Fact 253a5ce0

Store id: 72f4e3b3-edb1-45a1-98e7-ddc6769a75fd

## Text

```text
def _validate_force_insert(cls, force_insert)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5336480+00:00`

## Data

```json
{
  "end_line": 948,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 930,
  "symbol": "Model._validate_force_insert"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":930,"selector":"L930-L948","symbol":"Model._validate_force_insert"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._validate_force_insert](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 948,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 930,
    "symbol": "Model._validate_force_insert"
  },
  "id": "72f4e3b3-edb1-45a1-98e7-ddc6769a75fd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5336480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 930,
        "selector": "L930-L948",
        "symbol": "Model._validate_force_insert"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "d455bfba-67ab-4cb9-953d-967538c9d386",
  "subject_name": "django/db/models/base::Model._validate_force_insert",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _validate_force_insert(cls, force_insert)"
}
```

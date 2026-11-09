# Fact 245c2123

Store id: 8ed68eff-4b3f-49f3-bc85-a85ed1ecfe8c

## Text

```text
def _check_single_primary_key(cls)
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
- posted_at: `2026-11-09T23:44:48.5512210+00:00`

## Data

```json
{
  "end_line": 2163,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2151,
  "symbol": "Model._check_single_primary_key"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2151,"selector":"L2151-L2163","symbol":"Model._check_single_primary_key"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_single_primary_key](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2163,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2151,
    "symbol": "Model._check_single_primary_key"
  },
  "id": "8ed68eff-4b3f-49f3-bc85-a85ed1ecfe8c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5512210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2151,
        "selector": "L2151-L2163",
        "symbol": "Model._check_single_primary_key"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "7b0985f4-58d6-48ad-ae9e-97beb25b481c",
  "subject_name": "django/db/models/base::Model._check_single_primary_key",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_single_primary_key(cls)"
}
```

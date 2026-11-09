# Fact 245c2123

Store id: 7e5bc011-38f4-46db-bae7-50d4d2e5105a

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
- posted_at: `2026-11-09T23:31:53.7662920+00:00`

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
  "id": "7e5bc011-38f4-46db-bae7-50d4d2e5105a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7662920+00:00"
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
  "subject_id": "ae645d0b-571a-4187-a181-b3cc22ff9c8e",
  "subject_name": "django/db/models/base::Model._check_single_primary_key",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_single_primary_key(cls)"
}
```

# Fact af7ae838

Store id: dd2408ff-5412-499f-a503-4c26f28149bc

## Text

```text
def check(cls, **kwargs)
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
- posted_at: `2026-11-09T22:39:40.3540950+00:00`

## Data

```json
{
  "end_line": 1811,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1775,
  "symbol": "Model.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1775,"selector":"L1775-L1811","symbol":"Model.check"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1811,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1775,
    "symbol": "Model.check"
  },
  "id": "dd2408ff-5412-499f-a503-4c26f28149bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3540950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1775,
        "selector": "L1775-L1811",
        "symbol": "Model.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "b62ff6d9-12a5-4f96-81f6-78b50e287a0b",
  "subject_name": "django/db/models/base::Model.check",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def check(cls, **kwargs)"
}
```

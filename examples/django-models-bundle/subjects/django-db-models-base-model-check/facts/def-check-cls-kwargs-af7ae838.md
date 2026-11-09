# Fact af7ae838

Store id: 2908bc12-58a4-4430-b49a-8192b68a27da

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
- posted_at: `2026-11-09T23:31:53.7604290+00:00`

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
  "id": "2908bc12-58a4-4430-b49a-8192b68a27da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7604290+00:00"
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
  "subject_id": "ac781bab-68bf-4c97-8ed7-d4d0d8f3eb6a",
  "subject_name": "django/db/models/base::Model.check",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def check(cls, **kwargs)"
}
```

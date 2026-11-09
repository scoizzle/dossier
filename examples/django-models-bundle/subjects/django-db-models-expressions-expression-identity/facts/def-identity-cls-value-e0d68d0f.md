# Fact e0d68d0f

Store id: e754d440-e699-4c0c-869c-a4e42db6df19

## Text

```text
def _identity(cls, value)
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
- posted_at: `2026-11-09T22:39:41.5369680+00:00`

## Data

```json
{
  "end_line": 538,
  "entity_kind": "class_method",
  "parent": "Expression",
  "start_line": 528,
  "symbol": "Expression._identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":528,"selector":"L528-L538","symbol":"Expression._identity"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression._identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 538,
    "entity_kind": "class_method",
    "parent": "Expression",
    "start_line": 528,
    "symbol": "Expression._identity"
  },
  "id": "e754d440-e699-4c0c-869c-a4e42db6df19",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5369680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 528,
        "selector": "L528-L538",
        "symbol": "Expression._identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6456b647-a7e2-43cd-9085-c52d90448a28",
  "subject_name": "django/db/models/expressions::Expression._identity",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _identity(cls, value)"
}
```

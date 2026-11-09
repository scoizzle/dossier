# Fact e0d68d0f

Store id: 767294b9-af37-48d7-8a02-59bb8588dcc5

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
- posted_at: `2026-11-09T23:44:49.4242900+00:00`

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
  "id": "767294b9-af37-48d7-8a02-59bb8588dcc5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4242900+00:00"
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
  "subject_id": "f92deac3-d559-4bc7-bc4a-5f910688cbd2",
  "subject_name": "django/db/models/expressions::Expression._identity",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _identity(cls, value)"
}
```

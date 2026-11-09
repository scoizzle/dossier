# Fact edd33c7b

Store id: f8b2fb97-2860-4d1c-9dad-12366f1ba42f

## Text

```text
def __init__(self, expression, collation)
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
- posted_at: `2026-11-09T23:44:53.1598250+00:00`

## Data

```json
{
  "end_line": 116,
  "entity_kind": "method",
  "parent": "Collate",
  "start_line": 112,
  "symbol": "Collate.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":112,"selector":"L112-L116","symbol":"Collate.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Collate.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 116,
    "entity_kind": "method",
    "parent": "Collate",
    "start_line": 112,
    "symbol": "Collate.__init__"
  },
  "id": "f8b2fb97-2860-4d1c-9dad-12366f1ba42f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1598250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 112,
        "selector": "L112-L116",
        "symbol": "Collate.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "654f9443-8b64-49af-86fa-d00f176c09af",
  "subject_name": "django/db/models/functions/comparison::Collate.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, collation)"
}
```

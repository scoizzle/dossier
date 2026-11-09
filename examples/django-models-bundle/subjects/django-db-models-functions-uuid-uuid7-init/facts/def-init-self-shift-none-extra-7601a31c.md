# Fact 7601a31c

Store id: 34426f21-cd95-4bdc-afc3-ac5d18e81537

## Text

```text
def __init__(self, shift=None, **extra)
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
- posted_at: `2026-11-09T23:44:54.3217560+00:00`

## Data

```json
{
  "end_line": 53,
  "entity_kind": "method",
  "parent": "UUID7",
  "start_line": 52,
  "symbol": "UUID7.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"selector":"L52-L53","symbol":"UUID7.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID7.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 53,
    "entity_kind": "method",
    "parent": "UUID7",
    "start_line": 52,
    "symbol": "UUID7.__init__"
  },
  "id": "34426f21-cd95-4bdc-afc3-ac5d18e81537",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.3217560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 52,
        "selector": "L52-L53",
        "symbol": "UUID7.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "5f76cd30-2955-474b-8330-0892304106e3",
  "subject_name": "django/db/models/functions/uuid::UUID7.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, shift=None, **extra)"
}
```

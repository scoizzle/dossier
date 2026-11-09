# Fact 7601a31c

Store id: ecb420d2-0b84-4819-8668-7e0662c5d691

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
- posted_at: `2026-11-09T22:39:47.3792880+00:00`

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
  "id": "ecb420d2-0b84-4819-8668-7e0662c5d691",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3792880+00:00"
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
  "subject_id": "f2627d1b-8457-43b1-ae46-02a3d881a48b",
  "subject_name": "django/db/models/functions/uuid::UUID7.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, shift=None, **extra)"
}
```

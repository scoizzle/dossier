# Fact 9082055e

Store id: 7353f522-829b-4e68-8069-68653d1bcb10

## Text

```text
def __init__(self, msg, protected_objects)
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
- posted_at: `2026-11-09T22:39:40.9750010+00:00`

## Data

```json
{
  "end_line": 13,
  "entity_kind": "method",
  "parent": "ProtectedError",
  "start_line": 11,
  "symbol": "ProtectedError.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":11,"selector":"L11-L13","symbol":"ProtectedError.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::ProtectedError.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 13,
    "entity_kind": "method",
    "parent": "ProtectedError",
    "start_line": 11,
    "symbol": "ProtectedError.__init__"
  },
  "id": "7353f522-829b-4e68-8069-68653d1bcb10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.9750010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 11,
        "selector": "L11-L13",
        "symbol": "ProtectedError.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "8af477f0-c202-46e9-82a0-c8f6f25d8160",
  "subject_name": "django/db/models/deletion::ProtectedError.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, msg, protected_objects)"
}
```

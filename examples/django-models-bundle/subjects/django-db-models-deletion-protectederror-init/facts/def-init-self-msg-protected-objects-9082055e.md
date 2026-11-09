# Fact 9082055e

Store id: f7f4077c-a01d-4969-9713-bfbbe4efd3a3

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
- posted_at: `2026-11-09T23:31:55.0170450+00:00`

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
  "id": "f7f4077c-a01d-4969-9713-bfbbe4efd3a3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0170450+00:00"
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
  "subject_id": "7ea4f703-3046-4925-8078-b22a4aceb283",
  "subject_name": "django/db/models/deletion::ProtectedError.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, msg, protected_objects)"
}
```

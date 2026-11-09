# Fact 5f18655d

Store id: 9ec3cc05-e216-433b-a4f1-7f5be012f242

## Text

```text
def __init__(self, model)
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
- posted_at: `2026-11-09T23:32:03.7287760+00:00`

## Data

```json
{
  "end_line": 210,
  "entity_kind": "method",
  "parent": "EmptyManager",
  "start_line": 208,
  "symbol": "EmptyManager.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":208,"selector":"L208-L210","symbol":"EmptyManager.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::EmptyManager.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 210,
    "entity_kind": "method",
    "parent": "EmptyManager",
    "start_line": 208,
    "symbol": "EmptyManager.__init__"
  },
  "id": "9ec3cc05-e216-433b-a4f1-7f5be012f242",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7287760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 208,
        "selector": "L208-L210",
        "symbol": "EmptyManager.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "9344ec48-f543-4250-9320-6205fee78f03",
  "subject_name": "django/db/models/manager::EmptyManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model)"
}
```

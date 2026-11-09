# Fact be712330

Store id: 1c3d6dfd-fba6-4b74-8856-c87e2f24181e

## Text

```text
def __init__( self, *, condition, name, violation_error_code=None, violation_error_message=None, )
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
- posted_at: `2026-11-09T22:39:40.7090880+00:00`

## Data

```json
{
  "end_line": 153,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 136,
  "symbol": "CheckConstraint.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":136,"selector":"L136-L153","symbol":"CheckConstraint.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 153,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 136,
    "symbol": "CheckConstraint.__init__"
  },
  "id": "1c3d6dfd-fba6-4b74-8856-c87e2f24181e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7090880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 136,
        "selector": "L136-L153",
        "symbol": "CheckConstraint.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "16789d27-5e44-4f5c-ac24-e99b75150c49",
  "subject_name": "django/db/models/constraints::CheckConstraint.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *, condition, name, violation_error_code=None, violation_error_message=None, )"
}
```

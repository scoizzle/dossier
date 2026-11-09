# Fact be712330

Store id: dc7d0668-e96a-427d-b36c-2695d559a333

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
- posted_at: `2026-11-09T23:44:48.7776250+00:00`

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
  "id": "dc7d0668-e96a-427d-b36c-2695d559a333",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7776250+00:00"
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
  "subject_id": "6fca75cf-2788-4b8e-a36b-294e11c84749",
  "subject_name": "django/db/models/constraints::CheckConstraint.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *, condition, name, violation_error_code=None, violation_error_message=None, )"
}
```

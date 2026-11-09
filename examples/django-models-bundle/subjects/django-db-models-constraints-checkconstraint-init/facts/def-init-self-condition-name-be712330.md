# Fact be712330

Store id: ddf38b0a-838b-4f7d-8be8-d9a3318e3768

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
- posted_at: `2026-11-09T23:31:54.1636910+00:00`

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
  "id": "ddf38b0a-838b-4f7d-8be8-d9a3318e3768",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1636910+00:00"
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
  "subject_id": "95da1586-73e7-4357-994c-52c9e203cc3f",
  "subject_name": "django/db/models/constraints::CheckConstraint.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *, condition, name, violation_error_code=None, violation_error_message=None, )"
}
```

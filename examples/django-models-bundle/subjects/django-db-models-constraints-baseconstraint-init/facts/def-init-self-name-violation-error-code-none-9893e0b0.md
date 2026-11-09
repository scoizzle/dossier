# Fact 9893e0b0

Store id: 7a336665-8c15-43ff-8de8-1548e3c42524

## Text

```text
def __init__( self, *, name, violation_error_code=None, violation_error_message=None )
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
- posted_at: `2026-11-09T23:31:54.1362970+00:00`

## Data

```json
{
  "end_line": 37,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 28,
  "symbol": "BaseConstraint.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":28,"selector":"L28-L37","symbol":"BaseConstraint.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 37,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 28,
    "symbol": "BaseConstraint.__init__"
  },
  "id": "7a336665-8c15-43ff-8de8-1548e3c42524",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1362970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 28,
        "selector": "L28-L37",
        "symbol": "BaseConstraint.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "40f1553e-07ed-4ec7-afa7-a684253a16a5",
  "subject_name": "django/db/models/constraints::BaseConstraint.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *, name, violation_error_code=None, violation_error_message=None )"
}
```

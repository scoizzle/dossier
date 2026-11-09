# Fact 9893e0b0

Store id: 72d17cc2-cb05-4659-8bde-ae44df546b79

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
- posted_at: `2026-11-09T22:39:40.6979200+00:00`

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
  "id": "72d17cc2-cb05-4659-8bde-ae44df546b79",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.6979200+00:00"
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
  "subject_id": "cac306b0-4c75-4c13-8e63-870508e224ff",
  "subject_name": "django/db/models/constraints::BaseConstraint.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *, name, violation_error_code=None, violation_error_message=None )"
}
```

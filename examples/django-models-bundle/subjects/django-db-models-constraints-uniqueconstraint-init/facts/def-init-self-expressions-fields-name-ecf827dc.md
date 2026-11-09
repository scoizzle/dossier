# Fact ecf827dc

Store id: 080b03d2-b750-4bd5-b192-02b88a45ad46

## Text

```text
def __init__( self, *expressions, fields=(), name, condition=None, deferrable=None, include=None, opclasses=(), nulls_distinct=None, violation_error_code=None, violation_error_message=None, )
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
- posted_at: `2026-11-09T23:44:48.7849180+00:00`

## Data

```json
{
  "end_line": 338,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 270,
  "symbol": "UniqueConstraint.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":270,"selector":"L270-L338","symbol":"UniqueConstraint.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 338,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 270,
    "symbol": "UniqueConstraint.__init__"
  },
  "id": "080b03d2-b750-4bd5-b192-02b88a45ad46",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7849180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 270,
        "selector": "L270-L338",
        "symbol": "UniqueConstraint.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "20d3cce2-eaa4-4c98-b372-a053195b7599",
  "subject_name": "django/db/models/constraints::UniqueConstraint.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *expressions, fields=(), name, condition=None, deferrable=None, include=None, opclasses=(), nulls_distinct=None, violation_error_code=None, violation_error_message=None, )"
}
```

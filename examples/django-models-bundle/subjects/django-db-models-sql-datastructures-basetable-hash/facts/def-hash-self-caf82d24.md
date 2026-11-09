# Fact caf82d24

Store id: 1be003ae-ed5f-4eb4-93d2-2b6d8ea6054d

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:32:06.5033730+00:00`

## Data

```json
{
  "end_line": 222,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 221,
  "symbol": "BaseTable.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":221,"selector":"L221-L222","symbol":"BaseTable.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 222,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 221,
    "symbol": "BaseTable.__hash__"
  },
  "id": "1be003ae-ed5f-4eb4-93d2-2b6d8ea6054d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.5033730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 221,
        "selector": "L221-L222",
        "symbol": "BaseTable.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "d0958fc4-7564-490e-aa39-e523542e1a2d",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```

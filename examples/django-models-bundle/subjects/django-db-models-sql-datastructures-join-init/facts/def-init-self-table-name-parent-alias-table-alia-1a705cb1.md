# Fact 1a705cb1

Store id: f8c3a781-2970-4200-90d9-e30856224a04

## Text

```text
def __init__( self, table_name, parent_alias, table_alias, join_type, join_field, nullable, filtered_relation=None, )
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
- posted_at: `2026-11-09T23:32:06.4500400+00:00`

## Data

```json
{
  "end_line": 74,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 46,
  "symbol": "Join.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":46,"selector":"L46-L74","symbol":"Join.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 74,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 46,
    "symbol": "Join.__init__"
  },
  "id": "f8c3a781-2970-4200-90d9-e30856224a04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4500400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 46,
        "selector": "L46-L74",
        "symbol": "Join.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "d7cdd98e-49f1-40ab-bf7c-9a15261ea343",
  "subject_name": "django/db/models/sql/datastructures::Join.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, table_name, parent_alias, table_alias, join_type, join_field, nullable, filtered_relation=None, )"
}
```

# Fact 1a705cb1

Store id: c0d9db43-c593-476a-b8da-4dd14525aaf3

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
- posted_at: `2026-11-09T23:44:58.1983550+00:00`

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
  "id": "c0d9db43-c593-476a-b8da-4dd14525aaf3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.1983550+00:00"
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
  "subject_id": "8acb15d0-6898-4426-80f2-d4ca7712c4d6",
  "subject_name": "django/db/models/sql/datastructures::Join.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, table_name, parent_alias, table_alias, join_type, join_field, nullable, filtered_relation=None, )"
}
```

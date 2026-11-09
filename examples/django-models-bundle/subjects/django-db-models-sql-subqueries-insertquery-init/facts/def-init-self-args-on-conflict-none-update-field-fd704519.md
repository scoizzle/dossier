# Fact fd704519

Store id: f21526e7-0236-4b1b-8fa9-24e3dda30fb9

## Text

```text
def __init__( self, *args, on_conflict=None, update_fields=None, unique_fields=None, **kwargs )
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
- posted_at: `2026-11-09T22:39:51.7613020+00:00`

## Data

```json
{
  "end_line": 159,
  "entity_kind": "method",
  "parent": "InsertQuery",
  "start_line": 151,
  "symbol": "InsertQuery.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":151,"selector":"L151-L159","symbol":"InsertQuery.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::InsertQuery.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 159,
    "entity_kind": "method",
    "parent": "InsertQuery",
    "start_line": 151,
    "symbol": "InsertQuery.__init__"
  },
  "id": "f21526e7-0236-4b1b-8fa9-24e3dda30fb9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7613020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 151,
        "selector": "L151-L159",
        "symbol": "InsertQuery.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "9693fa91-5bb6-4b99-ba54-a8cf9377e121",
  "subject_name": "django/db/models/sql/subqueries::InsertQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *args, on_conflict=None, update_fields=None, unique_fields=None, **kwargs )"
}
```

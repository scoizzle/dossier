# Fact fd704519

Store id: 39fdbb03-a974-49a0-a78f-6cbe59235b7c

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
- posted_at: `2026-11-09T23:44:59.4341830+00:00`

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
  "id": "39fdbb03-a974-49a0-a78f-6cbe59235b7c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.4341830+00:00"
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
  "subject_id": "8fee880a-de47-4e7e-84fb-a211dd3778e5",
  "subject_name": "django/db/models/sql/subqueries::InsertQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *args, on_conflict=None, update_fields=None, unique_fields=None, **kwargs )"
}
```

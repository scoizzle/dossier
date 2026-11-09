# Fact fd704519

Store id: dbef8971-7103-4d28-ba70-8eb532e70058

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
- posted_at: `2026-11-09T23:32:07.4059850+00:00`

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
  "id": "dbef8971-7103-4d28-ba70-8eb532e70058",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.4059850+00:00"
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
  "subject_id": "1ed629a5-b94c-4d8e-9519-92d8223d5c15",
  "subject_name": "django/db/models/sql/subqueries::InsertQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *args, on_conflict=None, update_fields=None, unique_fields=None, **kwargs )"
}
```

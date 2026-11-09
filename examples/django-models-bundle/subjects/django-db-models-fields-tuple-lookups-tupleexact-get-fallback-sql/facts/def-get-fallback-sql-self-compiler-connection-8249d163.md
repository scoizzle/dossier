# Fact 8249d163

Store id: 5e37cf9d-1724-4dc5-b599-2bbdb0ee4a60

## Text

```text
def get_fallback_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:00.5849650+00:00`

## Data

```json
{
  "end_line": 166,
  "entity_kind": "method",
  "parent": "TupleExact",
  "start_line": 156,
  "symbol": "TupleExact.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":156,"selector":"L156-L166","symbol":"TupleExact.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleExact.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 166,
    "entity_kind": "method",
    "parent": "TupleExact",
    "start_line": 156,
    "symbol": "TupleExact.get_fallback_sql"
  },
  "id": "5e37cf9d-1724-4dc5-b599-2bbdb0ee4a60",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5849650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 156,
        "selector": "L156-L166",
        "symbol": "TupleExact.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "3b0ad954-acf1-4df9-a741-5d7038e47009",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleExact.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```

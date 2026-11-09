# Fact 8249d163

Store id: fd05ecb1-b45b-4784-b3fd-9b7bf1f78e2c

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
- posted_at: `2026-11-09T22:39:45.5958980+00:00`

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
  "id": "fd05ecb1-b45b-4784-b3fd-9b7bf1f78e2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5958980+00:00"
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
  "subject_id": "5c386539-9fdb-404f-983b-ff03f6449b49",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleExact.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```

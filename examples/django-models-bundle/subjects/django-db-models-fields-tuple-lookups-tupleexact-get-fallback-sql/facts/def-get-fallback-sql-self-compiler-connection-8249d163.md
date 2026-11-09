# Fact 8249d163

Store id: b563501c-e519-4282-a80c-56edd7896171

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
- posted_at: `2026-11-09T23:44:52.7548300+00:00`

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
  "id": "b563501c-e519-4282-a80c-56edd7896171",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7548300+00:00"
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
  "subject_id": "7955988f-ef91-42c2-85aa-269802c2df68",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleExact.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```

# Fact 8f2faad7

Store id: a618f342-1974-4240-9b0e-da5a5f194045

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
- posted_at: `2026-11-09T22:39:45.6437220+00:00`

## Data

```json
{
  "end_line": 414,
  "entity_kind": "method",
  "parent": "TupleIn",
  "start_line": 377,
  "symbol": "TupleIn.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":377,"selector":"L377-L414","symbol":"TupleIn.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 414,
    "entity_kind": "method",
    "parent": "TupleIn",
    "start_line": 377,
    "symbol": "TupleIn.get_fallback_sql"
  },
  "id": "a618f342-1974-4240-9b0e-da5a5f194045",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6437220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 377,
        "selector": "L377-L414",
        "symbol": "TupleIn.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8dbbc0b5-5175-48cb-90b3-a47db3b82c47",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```

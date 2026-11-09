# Fact da45311b

Store id: 03997ee9-bfff-43ea-a968-b017d997c863

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
- posted_at: `2026-11-09T22:39:45.6149120+00:00`

## Data

```json
{
  "end_line": 244,
  "entity_kind": "method",
  "parent": "TupleGreaterThanOrEqual",
  "start_line": 220,
  "symbol": "TupleGreaterThanOrEqual.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":220,"selector":"L220-L244","symbol":"TupleGreaterThanOrEqual.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleGreaterThanOrEqual.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 244,
    "entity_kind": "method",
    "parent": "TupleGreaterThanOrEqual",
    "start_line": 220,
    "symbol": "TupleGreaterThanOrEqual.get_fallback_sql"
  },
  "id": "03997ee9-bfff-43ea-a968-b017d997c863",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6149120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 220,
        "selector": "L220-L244",
        "symbol": "TupleGreaterThanOrEqual.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d9f2f20c-0128-472a-b78c-3acdf3178889",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThanOrEqual.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```

# Fact da45311b

Store id: 80560bcc-9953-4bec-a2de-5a38c7c2205d

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
- posted_at: `2026-11-09T23:32:00.6061060+00:00`

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
  "id": "80560bcc-9953-4bec-a2de-5a38c7c2205d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6061060+00:00"
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
  "subject_id": "151e13c5-d3d6-4df4-a42b-2613fede79cb",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThanOrEqual.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```

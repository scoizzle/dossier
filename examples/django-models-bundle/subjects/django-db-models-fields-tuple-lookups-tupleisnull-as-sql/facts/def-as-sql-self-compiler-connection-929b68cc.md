# Fact 929b68cc

Store id: d2616311-612d-4d60-bea3-250df6633c78

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:00.5943780+00:00`

## Data

```json
{
  "end_line": 188,
  "entity_kind": "method",
  "parent": "TupleIsNull",
  "start_line": 180,
  "symbol": "TupleIsNull.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":180,"selector":"L180-L188","symbol":"TupleIsNull.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIsNull.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 188,
    "entity_kind": "method",
    "parent": "TupleIsNull",
    "start_line": 180,
    "symbol": "TupleIsNull.as_sql"
  },
  "id": "d2616311-612d-4d60-bea3-250df6633c78",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5943780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 180,
        "selector": "L180-L188",
        "symbol": "TupleIsNull.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a38544de-238f-4d60-b3af-b3f0437bb921",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIsNull.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```

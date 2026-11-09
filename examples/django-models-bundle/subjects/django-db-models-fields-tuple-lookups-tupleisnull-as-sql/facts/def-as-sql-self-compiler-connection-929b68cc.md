# Fact 929b68cc

Store id: 4a27f685-fea4-4871-868a-19d8323305f1

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
- posted_at: `2026-11-09T22:39:45.6036600+00:00`

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
  "id": "4a27f685-fea4-4871-868a-19d8323305f1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6036600+00:00"
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
  "subject_id": "a7485adc-2936-49a6-9c9b-16fe7172b030",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIsNull.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```

# Fact 02e9bff0

Store id: fdba00b4-a5c2-49f4-8bfe-a58c41a38400

## Text

```text
class TupleGreaterThanOrEqual(TupleLookupMixin, GreaterThanOrEqual)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:00.6034700+00:00`

## Data

```json
{
  "end_line": 244,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 219,
  "symbol": "TupleGreaterThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":219,"selector":"L219-L244","symbol":"TupleGreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleGreaterThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 244,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 219,
    "symbol": "TupleGreaterThanOrEqual"
  },
  "id": "fdba00b4-a5c2-49f4-8bfe-a58c41a38400",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6034700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 219,
        "selector": "L219-L244",
        "symbol": "TupleGreaterThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8bfa6a4d-a7e3-494a-83cb-381fe18119b2",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleGreaterThanOrEqual(TupleLookupMixin, GreaterThanOrEqual)"
}
```

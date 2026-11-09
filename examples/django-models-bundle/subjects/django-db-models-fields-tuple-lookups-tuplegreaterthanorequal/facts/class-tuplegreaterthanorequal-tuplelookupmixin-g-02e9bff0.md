# Fact 02e9bff0

Store id: 3e930d1f-52e6-43d3-be03-de3f0aab645f

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
- posted_at: `2026-11-09T23:44:52.7689500+00:00`

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
  "id": "3e930d1f-52e6-43d3-be03-de3f0aab645f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7689500+00:00"
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
  "subject_id": "c58b07c0-17d0-4514-9749-9984f4cbf762",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleGreaterThanOrEqual(TupleLookupMixin, GreaterThanOrEqual)"
}
```

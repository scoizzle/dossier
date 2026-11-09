# Fact b7f2b7ae

Store id: 77b969b5-76ce-46ff-bd2d-32c380dc3234

## Text

```text
def check_rhs_is_collection_of_tuples_or_lists(self)
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
- posted_at: `2026-11-09T23:32:00.6277190+00:00`

## Data

```json
{
  "end_line": 321,
  "entity_kind": "method",
  "parent": "TupleIn",
  "start_line": 315,
  "symbol": "TupleIn.check_rhs_is_collection_of_tuples_or_lists"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":315,"selector":"L315-L321","symbol":"TupleIn.check_rhs_is_collection_of_tuples_or_lists"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn.check_rhs_is_collection_of_tuples_or_lists](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 321,
    "entity_kind": "method",
    "parent": "TupleIn",
    "start_line": 315,
    "symbol": "TupleIn.check_rhs_is_collection_of_tuples_or_lists"
  },
  "id": "77b969b5-76ce-46ff-bd2d-32c380dc3234",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6277190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 315,
        "selector": "L315-L321",
        "symbol": "TupleIn.check_rhs_is_collection_of_tuples_or_lists"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8f5f3a8e-5b70-4caf-a6d9-5b353eabb20a",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.check_rhs_is_collection_of_tuples_or_lists",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_collection_of_tuples_or_lists(self)"
}
```

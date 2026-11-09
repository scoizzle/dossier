# Fact b776031f

Store id: 2e0d7229-646e-42c1-b492-f5b474d592f4

## Text

```text
class TupleGreaterThan(TupleLookupMixin, GreaterThan)
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
- posted_at: `2026-11-09T23:32:00.5972510+00:00`

## Data

```json
{
  "end_line": 216,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 191,
  "symbol": "TupleGreaterThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":191,"selector":"L191-L216","symbol":"TupleGreaterThan"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleGreaterThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 216,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 191,
    "symbol": "TupleGreaterThan"
  },
  "id": "2e0d7229-646e-42c1-b492-f5b474d592f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5972510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 191,
        "selector": "L191-L216",
        "symbol": "TupleGreaterThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "7419c836-04dc-4bfb-b633-18947894b0f8",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThan",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleGreaterThan(TupleLookupMixin, GreaterThan)"
}
```

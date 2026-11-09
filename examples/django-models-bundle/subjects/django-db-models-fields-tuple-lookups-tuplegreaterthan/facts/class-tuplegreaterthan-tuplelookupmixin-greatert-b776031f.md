# Fact b776031f

Store id: edbf46a1-8a72-4f6e-b4d3-d9e4c7ad0a87

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
- posted_at: `2026-11-09T22:39:45.6058560+00:00`

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
  "id": "edbf46a1-8a72-4f6e-b4d3-d9e4c7ad0a87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6058560+00:00"
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
  "subject_id": "fa515b70-c4e0-4dee-95ab-2c51caaeb36a",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThan",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleGreaterThan(TupleLookupMixin, GreaterThan)"
}
```

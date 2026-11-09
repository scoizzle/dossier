# Fact b776031f

Store id: 05f44473-1fa9-41c4-be0a-73079acd6f1b

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
- posted_at: `2026-11-09T23:44:52.7636640+00:00`

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
  "id": "05f44473-1fa9-41c4-be0a-73079acd6f1b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7636640+00:00"
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
  "subject_id": "03059e68-7800-4f3c-b1b4-7bde999d7460",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThan",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleGreaterThan(TupleLookupMixin, GreaterThan)"
}
```

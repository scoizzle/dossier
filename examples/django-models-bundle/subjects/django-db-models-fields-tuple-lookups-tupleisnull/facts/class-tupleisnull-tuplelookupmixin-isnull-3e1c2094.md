# Fact 3e1c2094

Store id: 5a563dda-d820-4fd2-b43a-99066f379e5d

## Text

```text
class TupleIsNull(TupleLookupMixin, IsNull)
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
- posted_at: `2026-11-09T23:44:52.7567990+00:00`

## Data

```json
{
  "end_line": 188,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 169,
  "symbol": "TupleIsNull"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":169,"selector":"L169-L188","symbol":"TupleIsNull"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIsNull](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 188,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 169,
    "symbol": "TupleIsNull"
  },
  "id": "5a563dda-d820-4fd2-b43a-99066f379e5d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7567990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 169,
        "selector": "L169-L188",
        "symbol": "TupleIsNull"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "3aa2ed08-38b1-40d2-ae3c-319889811380",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIsNull",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleIsNull(TupleLookupMixin, IsNull)"
}
```

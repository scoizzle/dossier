# Fact 07ab6506

Store id: efac47ec-fa44-4546-ad2d-cde6a7c1655d

## Text

```text
class TupleIn(TupleLookupMixin, In)
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
- posted_at: `2026-11-09T23:44:52.7866860+00:00`

## Data

```json
{
  "end_line": 414,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 303,
  "symbol": "TupleIn"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":303,"selector":"L303-L414","symbol":"TupleIn"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 414,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 303,
    "symbol": "TupleIn"
  },
  "id": "efac47ec-fa44-4546-ad2d-cde6a7c1655d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7866860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 303,
        "selector": "L303-L414",
        "symbol": "TupleIn"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "238048c7-326b-416d-91a0-8fc906f7c34f",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleIn(TupleLookupMixin, In)"
}
```

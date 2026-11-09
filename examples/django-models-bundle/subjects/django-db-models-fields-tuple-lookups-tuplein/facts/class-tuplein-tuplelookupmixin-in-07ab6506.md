# Fact 07ab6506

Store id: 1302ec65-2139-4b06-a375-ead80deab7f0

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
- posted_at: `2026-11-09T22:39:45.6292120+00:00`

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
  "id": "1302ec65-2139-4b06-a375-ead80deab7f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6292120+00:00"
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
  "subject_id": "76f73f9c-68d0-4dc8-9d77-b5c4f3e3e17d",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleIn(TupleLookupMixin, In)"
}
```

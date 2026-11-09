# Fact 07ab6506

Store id: 60e2933d-5a35-41d0-9c17-33e4eab14104

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
- posted_at: `2026-11-09T23:32:00.6211480+00:00`

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
  "id": "60e2933d-5a35-41d0-9c17-33e4eab14104",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6211480+00:00"
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
  "subject_id": "48f5c3a4-f156-48c6-baed-614a5a228e88",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleIn(TupleLookupMixin, In)"
}
```

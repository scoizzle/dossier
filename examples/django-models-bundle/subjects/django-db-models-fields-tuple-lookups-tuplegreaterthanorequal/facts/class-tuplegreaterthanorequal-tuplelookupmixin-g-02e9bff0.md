# Fact 02e9bff0

Store id: 733d91f7-4a15-4f37-bfe5-f69979fbba6c

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
- posted_at: `2026-11-09T22:39:45.6122540+00:00`

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
  "id": "733d91f7-4a15-4f37-bfe5-f69979fbba6c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6122540+00:00"
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
  "subject_id": "c2952c3f-f5bc-46b4-ac37-3757aac01e85",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleGreaterThanOrEqual(TupleLookupMixin, GreaterThanOrEqual)"
}
```

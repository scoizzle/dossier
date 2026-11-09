# Fact d1bbb8c4

Store id: 9928cb36-a926-4053-9edd-3e3c6b80d19e

## Text

```text
class AnyValue(Aggregate)
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
- posted_at: `2026-11-09T22:39:40.0389510+00:00`

## Data

```json
{
  "end_line": 237,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 226,
  "symbol": "AnyValue"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":226,"selector":"L226-L237","symbol":"AnyValue"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AnyValue](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 237,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 226,
    "symbol": "AnyValue"
  },
  "id": "9928cb36-a926-4053-9edd-3e3c6b80d19e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0389510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 226,
        "selector": "L226-L237",
        "symbol": "AnyValue"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "d2691440-7a5f-4c71-8b0d-6228efd1a80f",
  "subject_name": "django/db/models/aggregates::AnyValue",
  "tags": [
    "entity:class"
  ],
  "text": "class AnyValue(Aggregate)"
}
```

# Fact e1c0e6f5

Store id: 83112286-03b0-4f0f-80f7-2542e03f5482

## Text

```text
class TupleLessThan(TupleLookupMixin, LessThan)
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
- posted_at: `2026-11-09T22:39:45.6180850+00:00`

## Data

```json
{
  "end_line": 272,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 247,
  "symbol": "TupleLessThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":247,"selector":"L247-L272","symbol":"TupleLessThan"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 272,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 247,
    "symbol": "TupleLessThan"
  },
  "id": "83112286-03b0-4f0f-80f7-2542e03f5482",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6180850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 247,
        "selector": "L247-L272",
        "symbol": "TupleLessThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d99ce01b-4f32-4f90-afa2-91eed9c891c5",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThan",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleLessThan(TupleLookupMixin, LessThan)"
}
```

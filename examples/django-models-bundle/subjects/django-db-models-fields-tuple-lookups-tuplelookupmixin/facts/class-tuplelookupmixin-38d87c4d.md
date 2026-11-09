# Fact 38d87c4d

Store id: e0d491f0-e175-493f-bb2b-a8ced3254e70

## Text

```text
class TupleLookupMixin
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
- posted_at: `2026-11-09T23:32:00.5359500+00:00`

## Data

```json
{
  "end_line": 152,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 50,
  "symbol": "TupleLookupMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":50,"selector":"L50-L152","symbol":"TupleLookupMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 152,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 50,
    "symbol": "TupleLookupMixin"
  },
  "id": "e0d491f0-e175-493f-bb2b-a8ced3254e70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5359500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 50,
        "selector": "L50-L152",
        "symbol": "TupleLookupMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "968c4069-532b-4717-b70c-9c49d23380ec",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleLookupMixin"
}
```

# Fact 05553b23

Store id: 687ad430-b52b-4a32-bd05-aed2af227bc7

## Text

```text
class LessThan(FieldGetDbPrepValueMixin, BuiltinLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.2770940+00:00`

## Data

```json
{
  "end_line": 437,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 435,
  "symbol": "LessThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":435,"selector":"L435-L437","symbol":"LessThan"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::LessThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 437,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 435,
    "symbol": "LessThan"
  },
  "id": "687ad430-b52b-4a32-bd05-aed2af227bc7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2770940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 435,
        "selector": "L435-L437",
        "symbol": "LessThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e2d989f8-8e5d-4733-be52-a181e9b270b6",
  "subject_name": "django/db/models/lookups::LessThan",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class LessThan(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```

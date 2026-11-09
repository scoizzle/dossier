# Fact 59a511e6

Store id: 65ee9c07-f13a-46fd-8b32-34a484e33339

## Text

```text
class Range(FieldGetDbPrepValueIterableMixin, BuiltinLookup)
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
- posted_at: `2026-11-09T22:39:48.1962530+00:00`

## Data

```json
{
  "end_line": 662,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 657,
  "symbol": "Range"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":657,"selector":"L657-L662","symbol":"Range"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Range](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 662,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 657,
    "symbol": "Range"
  },
  "id": "65ee9c07-f13a-46fd-8b32-34a484e33339",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1962530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 657,
        "selector": "L657-L662",
        "symbol": "Range"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "44012269-d6ee-446e-b2ed-b62ada2deb4d",
  "subject_name": "django/db/models/lookups::Range",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Range(FieldGetDbPrepValueIterableMixin, BuiltinLookup)"
}
```

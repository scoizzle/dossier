# Fact 5f1da4b5

Store id: b73ea9f6-e7a9-4f90-8d3c-5e422d0b3506

## Text

```text
class UUIDStartsWith(UUIDTextMixin, StartsWith)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:UUIDField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.2867770+00:00`

## Data

```json
{
  "end_line": 817,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 815,
  "symbol": "UUIDStartsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":815,"selector":"L815-L817","symbol":"UUIDStartsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDStartsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 817,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 815,
    "symbol": "UUIDStartsWith"
  },
  "id": "b73ea9f6-e7a9-4f90-8d3c-5e422d0b3506",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2867770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 815,
        "selector": "L815-L817",
        "symbol": "UUIDStartsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "cce6352f-f7d7-4aae-8ff9-f5ac162466bb",
  "subject_name": "django/db/models/lookups::UUIDStartsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDStartsWith(UUIDTextMixin, StartsWith)"
}
```

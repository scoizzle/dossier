# Fact 5bb98854

Store id: fa09438b-d6bd-4197-99b0-58f602d12315

## Text

```text
class UUIDIEndsWith(UUIDTextMixin, IEndsWith)
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
- posted_at: `2026-11-09T22:39:48.3011420+00:00`

## Data

```json
{
  "end_line": 832,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 830,
  "symbol": "UUIDIEndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":830,"selector":"L830-L832","symbol":"UUIDIEndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDIEndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 832,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 830,
    "symbol": "UUIDIEndsWith"
  },
  "id": "fa09438b-d6bd-4197-99b0-58f602d12315",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.3011420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 830,
        "selector": "L830-L832",
        "symbol": "UUIDIEndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c321d838-0663-40b6-ad47-4c21f17bb479",
  "subject_name": "django/db/models/lookups::UUIDIEndsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIEndsWith(UUIDTextMixin, IEndsWith)"
}
```

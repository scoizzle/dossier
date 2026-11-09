# Fact 76efaf86

Store id: e1a9419f-dcf2-4f51-87ab-f2ed184ef315

## Text

```text
class UUIDIExact(UUIDTextMixin, IExact)
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
- posted_at: `2026-11-09T23:32:03.4721540+00:00`

## Data

```json
{
  "end_line": 802,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 800,
  "symbol": "UUIDIExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":800,"selector":"L800-L802","symbol":"UUIDIExact"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDIExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 802,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 800,
    "symbol": "UUIDIExact"
  },
  "id": "e1a9419f-dcf2-4f51-87ab-f2ed184ef315",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4721540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 800,
        "selector": "L800-L802",
        "symbol": "UUIDIExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "3c198ab3-e8d9-4701-bf2a-d0bf6c5fdd78",
  "subject_name": "django/db/models/lookups::UUIDIExact",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIExact(UUIDTextMixin, IExact)"
}
```

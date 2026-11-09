# Fact 76efaf86

Store id: 2ad634db-b546-44ed-bf4e-ad8e7610a5d1

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
- posted_at: `2026-11-09T22:39:48.2782290+00:00`

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
  "id": "2ad634db-b546-44ed-bf4e-ad8e7610a5d1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2782290+00:00"
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
  "subject_id": "c4aba017-b2e4-4e8a-bd85-df5b034d19bf",
  "subject_name": "django/db/models/lookups::UUIDIExact",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIExact(UUIDTextMixin, IExact)"
}
```

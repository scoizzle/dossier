# Fact d595305c

Store id: beddf8a8-1c77-4008-aac3-0faeaf9c8eb5

## Text

```text
class UUIDIStartsWith(UUIDTextMixin, IStartsWith)
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
- posted_at: `2026-11-09T23:32:03.4877080+00:00`

## Data

```json
{
  "end_line": 822,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 820,
  "symbol": "UUIDIStartsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":820,"selector":"L820-L822","symbol":"UUIDIStartsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDIStartsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 822,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 820,
    "symbol": "UUIDIStartsWith"
  },
  "id": "beddf8a8-1c77-4008-aac3-0faeaf9c8eb5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4877080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 820,
        "selector": "L820-L822",
        "symbol": "UUIDIStartsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "656a0a72-7f55-4a68-9fd2-515e9e416694",
  "subject_name": "django/db/models/lookups::UUIDIStartsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIStartsWith(UUIDTextMixin, IStartsWith)"
}
```

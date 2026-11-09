# Fact d595305c

Store id: b241becf-b104-468c-8d6c-8c31c599c0a0

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
- posted_at: `2026-11-09T23:44:55.1182640+00:00`

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
  "id": "b241becf-b104-468c-8d6c-8c31c599c0a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1182640+00:00"
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
  "subject_id": "bf878196-bb3d-4088-bb21-a6f853302e3f",
  "subject_name": "django/db/models/lookups::UUIDIStartsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIStartsWith(UUIDTextMixin, IStartsWith)"
}
```

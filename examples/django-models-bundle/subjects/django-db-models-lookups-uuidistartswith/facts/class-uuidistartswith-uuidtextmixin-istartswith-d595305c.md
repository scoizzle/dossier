# Fact d595305c

Store id: 753fb027-9dfd-440f-ae83-88c8c0c8a79d

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
- posted_at: `2026-11-09T22:39:48.2895920+00:00`

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
  "id": "753fb027-9dfd-440f-ae83-88c8c0c8a79d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2895920+00:00"
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
  "subject_id": "17740ecd-d8d1-49de-95d7-7a419f46ff6b",
  "subject_name": "django/db/models/lookups::UUIDIStartsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIStartsWith(UUIDTextMixin, IStartsWith)"
}
```

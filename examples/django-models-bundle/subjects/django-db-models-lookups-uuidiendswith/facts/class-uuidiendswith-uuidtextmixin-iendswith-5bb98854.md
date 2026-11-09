# Fact 5bb98854

Store id: 5a583383-ab12-4187-b396-665036b672ca

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
- posted_at: `2026-11-09T23:44:55.1280960+00:00`

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
  "id": "5a583383-ab12-4187-b396-665036b672ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1280960+00:00"
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
  "subject_id": "b100282d-aa6a-47bb-a258-4719585e7d15",
  "subject_name": "django/db/models/lookups::UUIDIEndsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIEndsWith(UUIDTextMixin, IEndsWith)"
}
```

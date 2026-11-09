# Fact 5bb98854

Store id: 044f820b-12b1-4e6f-97a9-7f9528bc2be3

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
- posted_at: `2026-11-09T23:32:03.4976630+00:00`

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
  "id": "044f820b-12b1-4e6f-97a9-7f9528bc2be3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4976630+00:00"
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
  "subject_id": "beb39e70-6aa0-4ae1-ac44-c2ba284fcfea",
  "subject_name": "django/db/models/lookups::UUIDIEndsWith",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIEndsWith(UUIDTextMixin, IEndsWith)"
}
```

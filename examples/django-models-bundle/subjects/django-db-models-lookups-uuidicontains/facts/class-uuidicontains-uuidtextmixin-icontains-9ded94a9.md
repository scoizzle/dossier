# Fact 9ded94a9

Store id: 01117c61-811e-45b8-8129-97659ae0e65d

## Text

```text
class UUIDIContains(UUIDTextMixin, IContains)
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
- posted_at: `2026-11-09T23:44:55.1117310+00:00`

## Data

```json
{
  "end_line": 812,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 810,
  "symbol": "UUIDIContains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":810,"selector":"L810-L812","symbol":"UUIDIContains"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDIContains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 812,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 810,
    "symbol": "UUIDIContains"
  },
  "id": "01117c61-811e-45b8-8129-97659ae0e65d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1117310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 810,
        "selector": "L810-L812",
        "symbol": "UUIDIContains"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "20d7683a-a227-4402-aa18-6861e1ecd3cd",
  "subject_name": "django/db/models/lookups::UUIDIContains",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIContains(UUIDTextMixin, IContains)"
}
```

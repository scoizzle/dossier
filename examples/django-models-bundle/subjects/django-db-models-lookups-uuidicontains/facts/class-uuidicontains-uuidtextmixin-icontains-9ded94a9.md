# Fact 9ded94a9

Store id: 5c478285-0d47-4d44-b120-fdacf158029e

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
- posted_at: `2026-11-09T22:39:48.2840790+00:00`

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
  "id": "5c478285-0d47-4d44-b120-fdacf158029e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2840790+00:00"
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
  "subject_id": "2c1b6464-3816-49f6-a229-25265bd7d0f1",
  "subject_name": "django/db/models/lookups::UUIDIContains",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDIContains(UUIDTextMixin, IContains)"
}
```

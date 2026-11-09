# Fact 603db0d9

Store id: 1746b11c-620f-4f4c-ae43-2b627085fea5

## Text

```text
class Reverse(Transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:02.2552020+00:00`

## Data

```json
{
  "end_line": 279,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 260,
  "symbol": "Reverse"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":260,"selector":"L260-L279","symbol":"Reverse"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Reverse](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 279,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 260,
    "symbol": "Reverse"
  },
  "id": "1746b11c-620f-4f4c-ae43-2b627085fea5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2552020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 260,
        "selector": "L260-L279",
        "symbol": "Reverse"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "165ed61c-a426-45f7-a084-5cbc75ebe8b3",
  "subject_name": "django/db/models/functions/text::Reverse",
  "tags": [
    "entity:class"
  ],
  "text": "class Reverse(Transform)"
}
```

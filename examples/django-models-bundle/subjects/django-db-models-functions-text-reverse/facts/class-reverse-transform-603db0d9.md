# Fact 603db0d9

Store id: 1e59a27b-91ce-4e17-aacb-c0ec887a1471

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
- posted_at: `2026-11-09T23:44:54.1278680+00:00`

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
  "id": "1e59a27b-91ce-4e17-aacb-c0ec887a1471",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1278680+00:00"
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
  "subject_id": "b31ea27d-7388-46df-b4f4-6c261fdcfb1a",
  "subject_name": "django/db/models/functions/text::Reverse",
  "tags": [
    "entity:class"
  ],
  "text": "class Reverse(Transform)"
}
```

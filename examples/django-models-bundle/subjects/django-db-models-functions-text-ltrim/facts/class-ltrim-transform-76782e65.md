# Fact 76782e65

Store id: bbbbe01b-7199-424c-a36c-e617674b2a0b

## Text

```text
class LTrim(Transform)
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
- posted_at: `2026-11-09T23:44:54.1058060+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 211,
  "symbol": "LTrim"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":211,"selector":"L211-L213","symbol":"LTrim"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::LTrim](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 211,
    "symbol": "LTrim"
  },
  "id": "bbbbe01b-7199-424c-a36c-e617674b2a0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1058060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 211,
        "selector": "L211-L213",
        "symbol": "LTrim"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "29d6aa36-d32e-4f70-8068-b56c4ce1461c",
  "subject_name": "django/db/models/functions/text::LTrim",
  "tags": [
    "entity:class"
  ],
  "text": "class LTrim(Transform)"
}
```

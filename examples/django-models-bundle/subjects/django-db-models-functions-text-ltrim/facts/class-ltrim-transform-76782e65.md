# Fact 76782e65

Store id: f99565a2-dfff-471a-aa27-0fe3bb11ca2c

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
- posted_at: `2026-11-09T23:32:02.2187100+00:00`

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
  "id": "f99565a2-dfff-471a-aa27-0fe3bb11ca2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2187100+00:00"
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
  "subject_id": "2f9ac18e-b4da-4d9f-9d9b-ef96264e92d2",
  "subject_name": "django/db/models/functions/text::LTrim",
  "tags": [
    "entity:class"
  ],
  "text": "class LTrim(Transform)"
}
```

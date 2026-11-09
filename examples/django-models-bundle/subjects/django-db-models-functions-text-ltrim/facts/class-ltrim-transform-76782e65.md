# Fact 76782e65

Store id: 84eba6c2-3f79-4eec-98d1-15aa968eecb6

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
- posted_at: `2026-11-09T22:39:47.1295110+00:00`

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
  "id": "84eba6c2-3f79-4eec-98d1-15aa968eecb6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1295110+00:00"
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
  "subject_id": "2f66e89f-1948-4a6f-a27c-b4ff25c21dba",
  "subject_name": "django/db/models/functions/text::LTrim",
  "tags": [
    "entity:class"
  ],
  "text": "class LTrim(Transform)"
}
```

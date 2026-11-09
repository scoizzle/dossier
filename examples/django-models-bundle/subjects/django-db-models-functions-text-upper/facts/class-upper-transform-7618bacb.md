# Fact 7618bacb

Store id: c2237ecd-a8ff-4395-9ba5-b7117417658f

## Text

```text
class Upper(Transform)
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
- posted_at: `2026-11-09T23:44:54.1782260+00:00`

## Data

```json
{
  "end_line": 377,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 375,
  "symbol": "Upper"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":375,"selector":"L375-L377","symbol":"Upper"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Upper](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 377,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 375,
    "symbol": "Upper"
  },
  "id": "c2237ecd-a8ff-4395-9ba5-b7117417658f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1782260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 375,
        "selector": "L375-L377",
        "symbol": "Upper"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "4fffccb0-2b2f-49c9-87da-89a10e4f45db",
  "subject_name": "django/db/models/functions/text::Upper",
  "tags": [
    "entity:class"
  ],
  "text": "class Upper(Transform)"
}
```

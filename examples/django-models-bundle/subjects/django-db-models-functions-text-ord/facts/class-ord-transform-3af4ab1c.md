# Fact 3af4ab1c

Store id: efe23f38-70e4-4a16-94ed-03011b8ee78e

## Text

```text
class Ord(Transform)
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
- posted_at: `2026-11-09T23:44:54.1101670+00:00`

## Data

```json
{
  "end_line": 230,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 221,
  "symbol": "Ord"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":221,"selector":"L221-L230","symbol":"Ord"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Ord](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 230,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 221,
    "symbol": "Ord"
  },
  "id": "efe23f38-70e4-4a16-94ed-03011b8ee78e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1101670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 221,
        "selector": "L221-L230",
        "symbol": "Ord"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "7c0f0514-c014-4968-8409-cf476312e465",
  "subject_name": "django/db/models/functions/text::Ord",
  "tags": [
    "entity:class"
  ],
  "text": "class Ord(Transform)"
}
```

# Fact 3af4ab1c

Store id: 348a4404-50d5-4684-8d8e-afa9880ea3de

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
- posted_at: `2026-11-09T22:39:47.1347150+00:00`

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
  "id": "348a4404-50d5-4684-8d8e-afa9880ea3de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1347150+00:00"
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
  "subject_id": "4773bb10-58a6-4205-ae81-d5d89fe9d7af",
  "subject_name": "django/db/models/functions/text::Ord",
  "tags": [
    "entity:class"
  ],
  "text": "class Ord(Transform)"
}
```

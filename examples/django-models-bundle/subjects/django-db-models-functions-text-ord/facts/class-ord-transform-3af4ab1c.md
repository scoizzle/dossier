# Fact 3af4ab1c

Store id: caccfdf7-4918-4249-8f62-c3ba2f9f8191

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
- posted_at: `2026-11-09T23:32:02.2267050+00:00`

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
  "id": "caccfdf7-4918-4249-8f62-c3ba2f9f8191",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2267050+00:00"
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
  "subject_id": "74915aa5-fa60-47ce-9ed7-22b75e95e7b1",
  "subject_name": "django/db/models/functions/text::Ord",
  "tags": [
    "entity:class"
  ],
  "text": "class Ord(Transform)"
}
```

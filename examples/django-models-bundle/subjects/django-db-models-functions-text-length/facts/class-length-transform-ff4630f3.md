# Fact ff4630f3

Store id: fc243f5d-d0e4-4faa-9f57-400c12209a86

## Text

```text
class Length(Transform)
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
- posted_at: `2026-11-09T22:39:47.1151800+00:00`

## Data

```json
{
  "end_line": 189,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 179,
  "symbol": "Length"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":179,"selector":"L179-L189","symbol":"Length"}`

## Items

```json
[
  {
    "text": "Return the number of characters in the expression.",
    "locator": {
      "line": 180
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/text::Length](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 189,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 179,
    "symbol": "Length"
  },
  "id": "fc243f5d-d0e4-4faa-9f57-400c12209a86",
  "items": [
    {
      "locator": {
        "line": 180
      },
      "text": "Return the number of characters in the expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1151800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 179,
        "selector": "L179-L189",
        "symbol": "Length"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "6eba96ea-871e-4f8d-b9b6-28e70a9c47cc",
  "subject_name": "django/db/models/functions/text::Length",
  "tags": [
    "entity:class"
  ],
  "text": "class Length(Transform)"
}
```

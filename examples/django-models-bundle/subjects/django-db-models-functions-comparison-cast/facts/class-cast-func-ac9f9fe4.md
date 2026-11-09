# Fact ac9f9fe4

Store id: fe6d5b6e-41d0-4ed6-a536-75a848cb58cd

## Text

```text
class Cast(Func)
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
- posted_at: `2026-11-09T23:44:53.0816800+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "class",
  "parent": "comparison",
  "start_line": 7,
  "symbol": "Cast"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":7,"selector":"L7-L67","symbol":"Cast"}`

## Items

```json
[
  {
    "text": "Coerce an expression to a new field type.",
    "locator": {
      "line": 8
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "class",
    "parent": "comparison",
    "start_line": 7,
    "symbol": "Cast"
  },
  "id": "fe6d5b6e-41d0-4ed6-a536-75a848cb58cd",
  "items": [
    {
      "locator": {
        "line": 8
      },
      "text": "Coerce an expression to a new field type."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.0816800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 7,
        "selector": "L7-L67",
        "symbol": "Cast"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "82768e17-a351-4720-bcd2-fd95d8f81706",
  "subject_name": "django/db/models/functions/comparison::Cast",
  "tags": [
    "entity:class"
  ],
  "text": "class Cast(Func)"
}
```

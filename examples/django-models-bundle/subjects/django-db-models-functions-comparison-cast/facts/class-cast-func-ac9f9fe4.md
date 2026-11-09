# Fact ac9f9fe4

Store id: f4a97474-d918-44d1-a628-6ed2f5adba14

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
- posted_at: `2026-11-09T22:39:45.8813460+00:00`

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
  "id": "f4a97474-d918-44d1-a628-6ed2f5adba14",
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
    "posted_at": "2026-11-09T22:39:45.8813460+00:00"
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
  "subject_id": "1a49eb3b-401b-4364-b32b-d9b8de12dee7",
  "subject_name": "django/db/models/functions/comparison::Cast",
  "tags": [
    "entity:class"
  ],
  "text": "class Cast(Func)"
}
```

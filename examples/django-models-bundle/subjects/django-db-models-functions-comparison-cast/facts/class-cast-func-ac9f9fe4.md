# Fact ac9f9fe4

Store id: f874231f-897b-4010-a10f-56397c6c0cd6

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
- posted_at: `2026-11-09T23:32:00.9296210+00:00`

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
  "id": "f874231f-897b-4010-a10f-56397c6c0cd6",
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
    "posted_at": "2026-11-09T23:32:00.9296210+00:00"
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
  "subject_id": "2552c40c-8ef9-428f-a591-3c47dfde6dbf",
  "subject_name": "django/db/models/functions/comparison::Cast",
  "tags": [
    "entity:class"
  ],
  "text": "class Cast(Func)"
}
```

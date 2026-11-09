# Fact 12d17ce6

Store id: 7cba10b9-640e-451f-8038-7b04f757d9ca

## Text

```text
class Coalesce(Func)
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
- posted_at: `2026-11-09T23:32:00.9645510+00:00`

## Data

```json
{
  "end_line": 101,
  "entity_kind": "class",
  "parent": "comparison",
  "start_line": 70,
  "symbol": "Coalesce"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":70,"selector":"L70-L101","symbol":"Coalesce"}`

## Items

```json
[
  {
    "text": "Return, from left to right, the first non-null expression.",
    "locator": {
      "line": 71
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Coalesce](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 101,
    "entity_kind": "class",
    "parent": "comparison",
    "start_line": 70,
    "symbol": "Coalesce"
  },
  "id": "7cba10b9-640e-451f-8038-7b04f757d9ca",
  "items": [
    {
      "locator": {
        "line": 71
      },
      "text": "Return, from left to right, the first non-null expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9645510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 70,
        "selector": "L70-L101",
        "symbol": "Coalesce"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "d3a9b65e-0bdc-466f-b2b0-d3eadae9671d",
  "subject_name": "django/db/models/functions/comparison::Coalesce",
  "tags": [
    "entity:class"
  ],
  "text": "class Coalesce(Func)"
}
```

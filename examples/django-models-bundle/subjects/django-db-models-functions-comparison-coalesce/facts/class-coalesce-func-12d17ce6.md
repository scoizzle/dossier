# Fact 12d17ce6

Store id: e5cb54e0-4a0c-461e-9b33-91ade1ab6795

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
- posted_at: `2026-11-09T23:44:53.1334500+00:00`

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
  "id": "e5cb54e0-4a0c-461e-9b33-91ade1ab6795",
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
    "posted_at": "2026-11-09T23:44:53.1334500+00:00"
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
  "subject_id": "da5af1a1-ea3d-44e9-b392-597e96a8344f",
  "subject_name": "django/db/models/functions/comparison::Coalesce",
  "tags": [
    "entity:class"
  ],
  "text": "class Coalesce(Func)"
}
```

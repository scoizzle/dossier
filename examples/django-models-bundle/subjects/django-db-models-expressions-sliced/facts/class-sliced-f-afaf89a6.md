# Fact afaf89a6

Store id: 29c4b5aa-1bf1-41c2-8421-4db41099d5af

## Text

```text
class Sliced(F)
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
- posted_at: `2026-11-09T22:39:41.5734580+00:00`

## Data

```json
{
  "end_line": 1050,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 996,
  "symbol": "Sliced"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":996,"selector":"L996-L1050","symbol":"Sliced"}`

## Items

```json
[
  {
    "text": "An object that contains a slice of an F expression.",
    "locator": {
      "line": 997
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Sliced](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1050,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 996,
    "symbol": "Sliced"
  },
  "id": "29c4b5aa-1bf1-41c2-8421-4db41099d5af",
  "items": [
    {
      "locator": {
        "line": 997
      },
      "text": "An object that contains a slice of an F expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5734580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 996,
        "selector": "L996-L1050",
        "symbol": "Sliced"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "09b45656-c689-4cff-a4d8-a0d27f83defd",
  "subject_name": "django/db/models/expressions::Sliced",
  "tags": [
    "entity:class"
  ],
  "text": "class Sliced(F)"
}
```

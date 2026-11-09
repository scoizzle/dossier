# Fact 50a06d7f

Store id: 89a68828-6d74-4318-8be2-949dd49cfe55

## Text

```text
class ExtractSecond(Extract)
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
- posted_at: `2026-11-09T22:39:46.1553650+00:00`

## Data

```json
{
  "end_line": 180,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 179,
  "symbol": "ExtractSecond"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":179,"selector":"L179-L180","symbol":"ExtractSecond"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractSecond](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 180,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 179,
    "symbol": "ExtractSecond"
  },
  "id": "89a68828-6d74-4318-8be2-949dd49cfe55",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1553650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 179,
        "selector": "L179-L180",
        "symbol": "ExtractSecond"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "10a7b275-855b-4e64-a27d-15fca52744e7",
  "subject_name": "django/db/models/functions/datetime::ExtractSecond",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractSecond(Extract)"
}
```

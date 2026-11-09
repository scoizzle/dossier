# Fact 482b6f10

Store id: dffae489-043a-4f71-b86d-d76fc038a1ae

## Text

```text
class Collate(Func)
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
- posted_at: `2026-11-09T23:32:00.9854820+00:00`

## Data

```json
{
  "end_line": 120,
  "entity_kind": "class",
  "parent": "comparison",
  "start_line": 104,
  "symbol": "Collate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":104,"selector":"L104-L120","symbol":"Collate"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Collate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 120,
    "entity_kind": "class",
    "parent": "comparison",
    "start_line": 104,
    "symbol": "Collate"
  },
  "id": "dffae489-043a-4f71-b86d-d76fc038a1ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9854820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 104,
        "selector": "L104-L120",
        "symbol": "Collate"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "f7b7ad14-a5b6-4a97-8427-1bfd9e27c8ba",
  "subject_name": "django/db/models/functions/comparison::Collate",
  "tags": [
    "entity:class"
  ],
  "text": "class Collate(Func)"
}
```

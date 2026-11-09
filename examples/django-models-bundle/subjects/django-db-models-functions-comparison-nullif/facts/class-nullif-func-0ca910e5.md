# Fact 0ca910e5

Store id: 850f3212-4ce0-4342-ae34-61a27cf98ef4

## Text

```text
class NullIf(Func)
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
- posted_at: `2026-11-09T23:32:01.0109360+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "class",
  "parent": "comparison",
  "start_line": 165,
  "symbol": "NullIf"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":165,"selector":"L165-L173","symbol":"NullIf"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::NullIf](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "class",
    "parent": "comparison",
    "start_line": 165,
    "symbol": "NullIf"
  },
  "id": "850f3212-4ce0-4342-ae34-61a27cf98ef4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.0109360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 165,
        "selector": "L165-L173",
        "symbol": "NullIf"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "520d26c5-a175-4c85-9ae6-68001a6d826c",
  "subject_name": "django/db/models/functions/comparison::NullIf",
  "tags": [
    "entity:class"
  ],
  "text": "class NullIf(Func)"
}
```

# Fact 0ca910e5

Store id: d1857363-152b-49e4-bf05-20276ac1f37a

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
- posted_at: `2026-11-09T22:39:45.9582670+00:00`

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
  "id": "d1857363-152b-49e4-bf05-20276ac1f37a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9582670+00:00"
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
  "subject_id": "51c4b638-4f9b-4bdb-a92e-88d9ff5ef0ea",
  "subject_name": "django/db/models/functions/comparison::NullIf",
  "tags": [
    "entity:class"
  ],
  "text": "class NullIf(Func)"
}
```

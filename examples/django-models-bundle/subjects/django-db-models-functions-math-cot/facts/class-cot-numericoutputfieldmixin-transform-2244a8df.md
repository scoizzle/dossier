# Fact 2244a8df

Store id: 470b7915-74b9-4867-a501-76353235733f

## Text

```text
class Cot(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.6015950+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 74,
  "symbol": "Cot"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L81","symbol":"Cot"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Cot](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 74,
    "symbol": "Cot"
  },
  "id": "470b7915-74b9-4867-a501-76353235733f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6015950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L81",
        "symbol": "Cot"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "524443fe-d151-450a-b3cc-572cb8a5876a",
  "subject_name": "django/db/models/functions/math::Cot",
  "tags": [
    "entity:class"
  ],
  "text": "class Cot(NumericOutputFieldMixin, Transform)"
}
```

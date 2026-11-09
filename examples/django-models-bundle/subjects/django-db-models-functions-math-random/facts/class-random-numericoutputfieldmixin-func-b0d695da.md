# Fact b0d695da

Store id: 91a21921-9cfa-4c57-a05b-dc0c1926d3c0

## Text

```text
class Random(NumericOutputFieldMixin, Func)
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
- posted_at: `2026-11-09T23:44:53.7502400+00:00`

## Data

```json
{
  "end_line": 175,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 159,
  "symbol": "Random"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":159,"selector":"L159-L175","symbol":"Random"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Random](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 175,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 159,
    "symbol": "Random"
  },
  "id": "91a21921-9cfa-4c57-a05b-dc0c1926d3c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7502400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 159,
        "selector": "L159-L175",
        "symbol": "Random"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "6d007881-bd4b-4af7-a6e5-b9143a5c923f",
  "subject_name": "django/db/models/functions/math::Random",
  "tags": [
    "entity:class"
  ],
  "text": "class Random(NumericOutputFieldMixin, Func)"
}
```

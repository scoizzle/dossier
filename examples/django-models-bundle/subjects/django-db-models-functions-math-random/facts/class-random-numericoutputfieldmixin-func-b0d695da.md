# Fact b0d695da

Store id: de32ad60-e032-454a-b38f-92099202ba6b

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
- posted_at: `2026-11-09T23:32:01.7415480+00:00`

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
  "id": "de32ad60-e032-454a-b38f-92099202ba6b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7415480+00:00"
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
  "subject_id": "c3435621-df9d-462e-bf07-3e5dc5c8d9c1",
  "subject_name": "django/db/models/functions/math::Random",
  "tags": [
    "entity:class"
  ],
  "text": "class Random(NumericOutputFieldMixin, Func)"
}
```

# Fact 7c71a974

Store id: 6d35cdf2-ff52-443a-9ed8-4e52587c3c31

## Text

```text
class ACos(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.5667350+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 18,
  "symbol": "ACos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":18,"selector":"L18-L20","symbol":"ACos"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::ACos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 18,
    "symbol": "ACos"
  },
  "id": "6d35cdf2-ff52-443a-9ed8-4e52587c3c31",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.5667350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 18,
        "selector": "L18-L20",
        "symbol": "ACos"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "fdbe6b60-fdda-4de3-b7de-a840b1349d7b",
  "subject_name": "django/db/models/functions/math::ACos",
  "tags": [
    "entity:class"
  ],
  "text": "class ACos(NumericOutputFieldMixin, Transform)"
}
```

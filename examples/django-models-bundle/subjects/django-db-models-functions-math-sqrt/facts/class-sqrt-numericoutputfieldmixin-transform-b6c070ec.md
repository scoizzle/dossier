# Fact b6c070ec

Store id: eec9402b-45ab-4265-8662-b1655047a7bc

## Text

```text
class Sqrt(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.6844880+00:00`

## Data

```json
{
  "end_line": 209,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 207,
  "symbol": "Sqrt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":207,"selector":"L207-L209","symbol":"Sqrt"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Sqrt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 209,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 207,
    "symbol": "Sqrt"
  },
  "id": "eec9402b-45ab-4265-8662-b1655047a7bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6844880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 207,
        "selector": "L207-L209",
        "symbol": "Sqrt"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "e225febf-b110-49a2-95be-cb105f42fb49",
  "subject_name": "django/db/models/functions/math::Sqrt",
  "tags": [
    "entity:class"
  ],
  "text": "class Sqrt(NumericOutputFieldMixin, Transform)"
}
```

# Fact 9520f410

Store id: 393642a3-b123-412b-a948-8af9d10d3616

## Text

```text
class Sin(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T23:44:53.7719810+00:00`

## Data

```json
{
  "end_line": 204,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 202,
  "symbol": "Sin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":202,"selector":"L202-L204","symbol":"Sin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Sin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 204,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 202,
    "symbol": "Sin"
  },
  "id": "393642a3-b123-412b-a948-8af9d10d3616",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7719810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 202,
        "selector": "L202-L204",
        "symbol": "Sin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "f8974367-4b67-47eb-9255-02017c0082b6",
  "subject_name": "django/db/models/functions/math::Sin",
  "tags": [
    "entity:class"
  ],
  "text": "class Sin(NumericOutputFieldMixin, Transform)"
}
```

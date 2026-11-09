# Fact 2a6d9b59

Store id: 28f11599-c042-417f-aada-92245507998d

## Text

```text
class ASin(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T23:32:01.6662820+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 23,
  "symbol": "ASin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":23,"selector":"L23-L25","symbol":"ASin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::ASin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 23,
    "symbol": "ASin"
  },
  "id": "28f11599-c042-417f-aada-92245507998d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.6662820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 23,
        "selector": "L23-L25",
        "symbol": "ASin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "98262b19-5a79-4115-877e-fa6a841f9747",
  "subject_name": "django/db/models/functions/math::ASin",
  "tags": [
    "entity:class"
  ],
  "text": "class ASin(NumericOutputFieldMixin, Transform)"
}
```

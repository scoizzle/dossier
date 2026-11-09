# Fact 910820af

Store id: 162268fa-ee64-496e-a1db-f3485fbc0b59

## Text

```text
class ATan(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.5716070+00:00`

## Data

```json
{
  "end_line": 30,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 28,
  "symbol": "ATan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":28,"selector":"L28-L30","symbol":"ATan"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::ATan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 30,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 28,
    "symbol": "ATan"
  },
  "id": "162268fa-ee64-496e-a1db-f3485fbc0b59",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.5716070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 28,
        "selector": "L28-L30",
        "symbol": "ATan"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "e42f517e-99c7-4edb-8bb6-1f2875362ea2",
  "subject_name": "django/db/models/functions/math::ATan",
  "tags": [
    "entity:class"
  ],
  "text": "class ATan(NumericOutputFieldMixin, Transform)"
}
```

# Fact 910820af

Store id: 0399ab64-bc55-47db-a173-b683083fae76

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
- posted_at: `2026-11-09T23:44:53.6923780+00:00`

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
  "id": "0399ab64-bc55-47db-a173-b683083fae76",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.6923780+00:00"
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
  "subject_id": "def79775-3929-43a5-97a4-59d2072d0456",
  "subject_name": "django/db/models/functions/math::ATan",
  "tags": [
    "entity:class"
  ],
  "text": "class ATan(NumericOutputFieldMixin, Transform)"
}
```

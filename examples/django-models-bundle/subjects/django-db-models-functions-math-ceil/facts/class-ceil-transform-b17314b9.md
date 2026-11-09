# Fact b17314b9

Store id: c96290b2-9686-4f4b-a290-700c87bb248c

## Text

```text
class Ceil(Transform)
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
- posted_at: `2026-11-09T23:32:01.6785450+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 61,
  "symbol": "Ceil"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":61,"selector":"L61-L66","symbol":"Ceil"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Ceil](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 61,
    "symbol": "Ceil"
  },
  "id": "c96290b2-9686-4f4b-a290-700c87bb248c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.6785450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 61,
        "selector": "L61-L66",
        "symbol": "Ceil"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "69704df4-f1ce-4103-bc98-6c19c854a1aa",
  "subject_name": "django/db/models/functions/math::Ceil",
  "tags": [
    "entity:class"
  ],
  "text": "class Ceil(Transform)"
}
```

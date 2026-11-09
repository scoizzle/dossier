# Fact 34758cf1

Store id: eff75f08-cd39-4bf4-8dbe-33f017615e18

## Text

```text
class Floor(Transform)
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
- posted_at: `2026-11-09T23:44:53.7276370+00:00`

## Data

```json
{
  "end_line": 104,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 102,
  "symbol": "Floor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":102,"selector":"L102-L104","symbol":"Floor"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Floor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 104,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 102,
    "symbol": "Floor"
  },
  "id": "eff75f08-cd39-4bf4-8dbe-33f017615e18",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7276370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 102,
        "selector": "L102-L104",
        "symbol": "Floor"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "00f2d136-812f-476e-adbc-d3729e21f9d7",
  "subject_name": "django/db/models/functions/math::Floor",
  "tags": [
    "entity:class"
  ],
  "text": "class Floor(Transform)"
}
```

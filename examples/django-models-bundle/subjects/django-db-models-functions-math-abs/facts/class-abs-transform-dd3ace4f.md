# Fact dd3ace4f

Store id: 30df4bb7-0bc0-45fd-a793-6a1208c39bdc

## Text

```text
class Abs(Transform)
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
- posted_at: `2026-11-09T23:44:53.6773720+00:00`

## Data

```json
{
  "end_line": 15,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 13,
  "symbol": "Abs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":13,"selector":"L13-L15","symbol":"Abs"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Abs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 15,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 13,
    "symbol": "Abs"
  },
  "id": "30df4bb7-0bc0-45fd-a793-6a1208c39bdc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.6773720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 13,
        "selector": "L13-L15",
        "symbol": "Abs"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "fab0a7ed-588b-435c-8587-6ed42694e9aa",
  "subject_name": "django/db/models/functions/math::Abs",
  "tags": [
    "entity:class"
  ],
  "text": "class Abs(Transform)"
}
```

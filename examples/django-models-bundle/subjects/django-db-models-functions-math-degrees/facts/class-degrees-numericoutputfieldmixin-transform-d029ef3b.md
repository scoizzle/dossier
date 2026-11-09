# Fact d029ef3b

Store id: 98bbeaf7-b84f-40c3-920b-825c1ada6e49

## Text

```text
class Degrees(NumericOutputFieldMixin, Transform)
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
- posted_at: `2026-11-09T23:32:01.7039640+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 84,
  "symbol": "Degrees"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"selector":"L84-L94","symbol":"Degrees"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Degrees](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 84,
    "symbol": "Degrees"
  },
  "id": "98bbeaf7-b84f-40c3-920b-825c1ada6e49",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7039640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 84,
        "selector": "L84-L94",
        "symbol": "Degrees"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "edef03f0-9a3b-451b-b6d3-ac3a1cd33720",
  "subject_name": "django/db/models/functions/math::Degrees",
  "tags": [
    "entity:class"
  ],
  "text": "class Degrees(NumericOutputFieldMixin, Transform)"
}
```

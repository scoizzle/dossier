# Fact 73b83350

Store id: 24ec92f2-47bd-4ef7-8d41-0aa07ca44caf

## Text

```text
class Case(SQLiteNumericMixin, Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:deconstructible`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.6211490+00:00`

## Data

```json
{
  "end_line": 1813,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1716,
  "symbol": "Case"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1716,"selector":"L1716-L1813","symbol":"Case"}`

## Items

```json
[
  {
    "text": "An SQL searched CASE expression:",
    "locator": {
      "line": 1718
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Case](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1813,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1716,
    "symbol": "Case"
  },
  "id": "24ec92f2-47bd-4ef7-8d41-0aa07ca44caf",
  "items": [
    {
      "locator": {
        "line": 1718
      },
      "text": "An SQL searched CASE expression:"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6211490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1716,
        "selector": "L1716-L1813",
        "symbol": "Case"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "21cdb5ba-eac9-49a0-b6e4-ed758345b3f0",
  "subject_name": "django/db/models/expressions::Case",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class Case(SQLiteNumericMixin, Expression)"
}
```

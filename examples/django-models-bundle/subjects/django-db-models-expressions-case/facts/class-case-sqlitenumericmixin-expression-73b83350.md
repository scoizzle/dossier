# Fact 73b83350

Store id: a939cf69-851b-491f-8bba-3c0d59a6a2da

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
- posted_at: `2026-11-09T22:39:41.7033300+00:00`

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
  "id": "a939cf69-851b-491f-8bba-3c0d59a6a2da",
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
    "posted_at": "2026-11-09T22:39:41.7033300+00:00"
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
  "subject_id": "2824962e-13ab-4fe3-92fd-854da159eed6",
  "subject_name": "django/db/models/expressions::Case",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class Case(SQLiteNumericMixin, Expression)"
}
```

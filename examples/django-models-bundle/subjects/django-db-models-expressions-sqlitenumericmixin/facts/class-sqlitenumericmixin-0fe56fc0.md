# Fact 0fe56fc0

Store id: dbb33e3b-3b80-4460-9a50-bc025c19805d

## Text

```text
class SQLiteNumericMixin
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
- posted_at: `2026-11-09T23:44:49.2252500+00:00`

## Data

```json
{
  "end_line": 35,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 22,
  "symbol": "SQLiteNumericMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":22,"selector":"L22-L35","symbol":"SQLiteNumericMixin"}`

## Items

```json
[
  {
    "text": "Some expressions with output_field=DecimalField() must be cast to numeric to be properly filtered.",
    "locator": {
      "line": 23
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::SQLiteNumericMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 35,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 22,
    "symbol": "SQLiteNumericMixin"
  },
  "id": "dbb33e3b-3b80-4460-9a50-bc025c19805d",
  "items": [
    {
      "locator": {
        "line": 23
      },
      "text": "Some expressions with output_field=DecimalField() must be cast to numeric to be properly filtered."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2252500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 22,
        "selector": "L22-L35",
        "symbol": "SQLiteNumericMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0e282c8f-849d-4f81-8af2-285b31afaf7e",
  "subject_name": "django/db/models/expressions::SQLiteNumericMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLiteNumericMixin"
}
```

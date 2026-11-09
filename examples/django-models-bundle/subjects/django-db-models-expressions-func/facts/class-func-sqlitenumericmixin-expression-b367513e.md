# Fact b367513e

Store id: 49a7f545-cc6b-4a0e-9dc8-3f0c1c1770b7

## Text

```text
class Func(SQLiteNumericMixin, Expression)
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
- posted_at: `2026-11-09T23:44:49.5068010+00:00`

## Data

```json
{
  "end_line": 1144,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1053,
  "symbol": "Func"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1053,"selector":"L1053-L1144","symbol":"Func"}`

## Items

```json
[
  {
    "text": "An SQL function call.",
    "locator": {
      "line": 1055
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Func](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1144,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1053,
    "symbol": "Func"
  },
  "id": "49a7f545-cc6b-4a0e-9dc8-3f0c1c1770b7",
  "items": [
    {
      "locator": {
        "line": 1055
      },
      "text": "An SQL function call."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5068010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1053,
        "selector": "L1053-L1144",
        "symbol": "Func"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4cc20d4b-63ea-439d-b332-940815b1268d",
  "subject_name": "django/db/models/expressions::Func",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class Func(SQLiteNumericMixin, Expression)"
}
```

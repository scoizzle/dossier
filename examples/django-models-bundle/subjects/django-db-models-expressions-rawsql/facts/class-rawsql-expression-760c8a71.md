# Fact 760c8a71

Store id: 84fc0151-fb82-43f4-a576-b36b57a1b4d9

## Text

```text
class RawSQL(Expression)
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
- posted_at: `2026-11-09T23:44:49.5371470+00:00`

## Data

```json
{
  "end_line": 1300,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1268,
  "symbol": "RawSQL"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1268,"selector":"L1268-L1300","symbol":"RawSQL"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1300,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1268,
    "symbol": "RawSQL"
  },
  "id": "84fc0151-fb82-43f4-a576-b36b57a1b4d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5371470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1268,
        "selector": "L1268-L1300",
        "symbol": "RawSQL"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "038242a9-4276-455d-aa7a-142f2df9848e",
  "subject_name": "django/db/models/expressions::RawSQL",
  "tags": [
    "entity:class"
  ],
  "text": "class RawSQL(Expression)"
}
```

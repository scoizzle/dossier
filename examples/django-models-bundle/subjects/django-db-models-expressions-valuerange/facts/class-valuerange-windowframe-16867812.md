# Fact 16867812

Store id: d1ae366d-2c62-41bf-8b82-ef341ff1520e

## Text

```text
class ValueRange(WindowFrame)
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
- posted_at: `2026-11-09T23:44:49.6955960+00:00`

## Data

```json
{
  "end_line": 2235,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 2231,
  "symbol": "ValueRange"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2231,"selector":"L2231-L2235","symbol":"ValueRange"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ValueRange](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2235,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 2231,
    "symbol": "ValueRange"
  },
  "id": "d1ae366d-2c62-41bf-8b82-ef341ff1520e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6955960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2231,
        "selector": "L2231-L2235",
        "symbol": "ValueRange"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3782a047-3050-4473-bd7b-9dcb04dc4f99",
  "subject_name": "django/db/models/expressions::ValueRange",
  "tags": [
    "entity:class"
  ],
  "text": "class ValueRange(WindowFrame)"
}
```

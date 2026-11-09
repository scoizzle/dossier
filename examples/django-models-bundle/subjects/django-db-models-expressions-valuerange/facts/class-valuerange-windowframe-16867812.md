# Fact 16867812

Store id: d9ec9e5b-a747-4a0d-89d8-73643cc507c6

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
- posted_at: `2026-11-09T23:31:56.0428890+00:00`

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
  "id": "d9ec9e5b-a747-4a0d-89d8-73643cc507c6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0428890+00:00"
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
  "subject_id": "d4c4be22-fe0f-4526-92eb-c505a7fe65a9",
  "subject_name": "django/db/models/expressions::ValueRange",
  "tags": [
    "entity:class"
  ],
  "text": "class ValueRange(WindowFrame)"
}
```

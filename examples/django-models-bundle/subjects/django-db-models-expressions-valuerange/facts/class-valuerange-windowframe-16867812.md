# Fact 16867812

Store id: 6623a044-ef26-4f41-9e56-93053b4bd57d

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
- posted_at: `2026-11-09T22:39:41.7940990+00:00`

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
  "id": "6623a044-ef26-4f41-9e56-93053b4bd57d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7940990+00:00"
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
  "subject_id": "39e5dd3b-1569-4aff-ad67-e1d4f3918411",
  "subject_name": "django/db/models/expressions::ValueRange",
  "tags": [
    "entity:class"
  ],
  "text": "class ValueRange(WindowFrame)"
}
```

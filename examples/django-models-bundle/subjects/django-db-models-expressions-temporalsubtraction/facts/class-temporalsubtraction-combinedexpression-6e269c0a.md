# Fact 6e269c0a

Store id: 69b6d96c-b151-4aca-8d5f-ea1f0c43c16c

## Text

```text
class TemporalSubtraction(CombinedExpression)
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
- posted_at: `2026-11-09T23:31:55.8254450+00:00`

## Data

```json
{
  "end_line": 878,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 866,
  "symbol": "TemporalSubtraction"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":866,"selector":"L866-L878","symbol":"TemporalSubtraction"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::TemporalSubtraction](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 878,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 866,
    "symbol": "TemporalSubtraction"
  },
  "id": "69b6d96c-b151-4aca-8d5f-ea1f0c43c16c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8254450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 866,
        "selector": "L866-L878",
        "symbol": "TemporalSubtraction"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2a08169b-51de-45cd-8ee6-67f355aa6f44",
  "subject_name": "django/db/models/expressions::TemporalSubtraction",
  "tags": [
    "entity:class"
  ],
  "text": "class TemporalSubtraction(CombinedExpression)"
}
```

# Fact 6e269c0a

Store id: 641aaa49-a8d3-45fe-a9de-a2869203782a

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
- posted_at: `2026-11-09T23:44:49.4547240+00:00`

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
  "id": "641aaa49-a8d3-45fe-a9de-a2869203782a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4547240+00:00"
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
  "subject_id": "8cba1a18-d4e7-4562-99bf-b09a40606344",
  "subject_name": "django/db/models/expressions::TemporalSubtraction",
  "tags": [
    "entity:class"
  ],
  "text": "class TemporalSubtraction(CombinedExpression)"
}
```

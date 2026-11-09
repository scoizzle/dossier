# Fact 9ea3e173

Store id: a09c65c3-33a1-429b-946d-76adc76b73c0

## Text

```text
class ColPairs(Expression)
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
- posted_at: `2026-11-09T22:39:41.6371770+00:00`

## Data

```json
{
  "end_line": 1444,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1390,
  "symbol": "ColPairs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1390,"selector":"L1390-L1444","symbol":"ColPairs"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1444,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1390,
    "symbol": "ColPairs"
  },
  "id": "a09c65c3-33a1-429b-946d-76adc76b73c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6371770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1390,
        "selector": "L1390-L1444",
        "symbol": "ColPairs"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b384036e-bc95-4c69-94a7-476a070b2d27",
  "subject_name": "django/db/models/expressions::ColPairs",
  "tags": [
    "entity:class"
  ],
  "text": "class ColPairs(Expression)"
}
```

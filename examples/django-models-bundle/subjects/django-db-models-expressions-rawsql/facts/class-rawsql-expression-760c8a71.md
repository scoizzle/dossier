# Fact 760c8a71

Store id: 5bdce5b8-8ad5-4b59-8c18-19a8c1661372

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
- posted_at: `2026-11-09T22:39:41.6064610+00:00`

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
  "id": "5bdce5b8-8ad5-4b59-8c18-19a8c1661372",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6064610+00:00"
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
  "subject_id": "a7170ce6-7c60-4b64-827d-35107bfcf7fc",
  "subject_name": "django/db/models/expressions::RawSQL",
  "tags": [
    "entity:class"
  ],
  "text": "class RawSQL(Expression)"
}
```

# Fact 78eb1dbb

Store id: b24ccfa5-50b0-4651-b0a2-77962fc11063

## Text

```text
def get_cols(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.6423370+00:00`

## Data

```json
{
  "end_line": 1413,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1409,
  "symbol": "ColPairs.get_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1409,"selector":"L1409-L1413","symbol":"ColPairs.get_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.get_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1413,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1409,
    "symbol": "ColPairs.get_cols"
  },
  "id": "b24ccfa5-50b0-4651-b0a2-77962fc11063",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6423370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1409,
        "selector": "L1409-L1413",
        "symbol": "ColPairs.get_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c8f93647-0156-49ed-9875-172ccfb0f23e",
  "subject_name": "django/db/models/expressions::ColPairs.get_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_cols(self)"
}
```

# Fact ff100c94

Store id: da56af9e-9980-428a-8a5f-dba07010e69e

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T22:39:41.6447670+00:00`

## Data

```json
{
  "end_line": 1421,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1418,
  "symbol": "ColPairs.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1418,"selector":"L1418-L1421","symbol":"ColPairs.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1421,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1418,
    "symbol": "ColPairs.set_source_expressions"
  },
  "id": "da56af9e-9980-428a-8a5f-dba07010e69e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6447670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1418,
        "selector": "L1418-L1421",
        "symbol": "ColPairs.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "01122ed5-cc8c-48e7-9668-84651651dd84",
  "subject_name": "django/db/models/expressions::ColPairs.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

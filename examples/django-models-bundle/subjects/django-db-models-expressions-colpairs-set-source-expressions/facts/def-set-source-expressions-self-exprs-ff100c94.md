# Fact ff100c94

Store id: e83cdb8f-4bfd-4d9c-89cc-56be3b74d34f

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
- posted_at: `2026-11-09T23:44:49.5657420+00:00`

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
  "id": "e83cdb8f-4bfd-4d9c-89cc-56be3b74d34f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5657420+00:00"
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
  "subject_id": "c4d74786-e5b8-4f1e-a9a0-11ad6c428d1d",
  "subject_name": "django/db/models/expressions::ColPairs.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

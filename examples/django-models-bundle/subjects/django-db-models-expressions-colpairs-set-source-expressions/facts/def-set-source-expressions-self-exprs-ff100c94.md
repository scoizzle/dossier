# Fact ff100c94

Store id: 0c5f80a1-b7e0-48d8-95ce-2af152ce61de

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
- posted_at: `2026-11-09T23:31:55.9051220+00:00`

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
  "id": "0c5f80a1-b7e0-48d8-95ce-2af152ce61de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9051220+00:00"
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
  "subject_id": "3a022815-1970-4eaa-a2c5-1436b653c68c",
  "subject_name": "django/db/models/expressions::ColPairs.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

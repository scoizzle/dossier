# Fact 1e6a381b

Store id: f1fffc39-0db9-491a-92e2-e4a134d4cf2f

## Text

```text
def select_format(self, compiler, sql, params)
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
- posted_at: `2026-11-09T23:31:55.9085460+00:00`

## Data

```json
{
  "end_line": 1444,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1443,
  "symbol": "ColPairs.select_format"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1443,"selector":"L1443-L1444","symbol":"ColPairs.select_format"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.select_format](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1444,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1443,
    "symbol": "ColPairs.select_format"
  },
  "id": "f1fffc39-0db9-491a-92e2-e4a134d4cf2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9085460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1443,
        "selector": "L1443-L1444",
        "symbol": "ColPairs.select_format"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ca5c22c0-5c01-456e-8c55-6ce51d3b7355",
  "subject_name": "django/db/models/expressions::ColPairs.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```

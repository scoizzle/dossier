# Fact 1e6a381b

Store id: 07999900-dedb-4f4a-82c5-2a081b9d58aa

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
- posted_at: `2026-11-09T23:44:49.5708020+00:00`

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
  "id": "07999900-dedb-4f4a-82c5-2a081b9d58aa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5708020+00:00"
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
  "subject_id": "6d3accb7-a6c2-4993-8f4a-7458761432d1",
  "subject_name": "django/db/models/expressions::ColPairs.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```

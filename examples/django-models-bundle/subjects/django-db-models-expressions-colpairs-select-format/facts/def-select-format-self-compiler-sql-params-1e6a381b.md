# Fact 1e6a381b

Store id: c6a68437-3da1-41bd-bb41-0de7938bb1ad

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
- posted_at: `2026-11-09T22:39:41.6482730+00:00`

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
  "id": "c6a68437-3da1-41bd-bb41-0de7938bb1ad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6482730+00:00"
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
  "subject_id": "9c0ca517-6c09-4575-9b78-27470e0dc32d",
  "subject_name": "django/db/models/expressions::ColPairs.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```

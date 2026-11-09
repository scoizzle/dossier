# Fact b0721c49

Store id: 374cdf08-6d2e-48bf-ae2f-1e9a9a29519a

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:31:55.9042990+00:00`

## Data

```json
{
  "end_line": 1416,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1415,
  "symbol": "ColPairs.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1415,"selector":"L1415-L1416","symbol":"ColPairs.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1416,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1415,
    "symbol": "ColPairs.get_source_expressions"
  },
  "id": "374cdf08-6d2e-48bf-ae2f-1e9a9a29519a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9042990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1415,
        "selector": "L1415-L1416",
        "symbol": "ColPairs.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "12b50907-ff71-440c-b42c-3b6aebabc026",
  "subject_name": "django/db/models/expressions::ColPairs.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

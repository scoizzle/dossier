# Fact b0721c49

Store id: 62439527-3516-44d4-9c91-b47e85402cff

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
- posted_at: `2026-11-09T23:44:49.5648740+00:00`

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
  "id": "62439527-3516-44d4-9c91-b47e85402cff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5648740+00:00"
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
  "subject_id": "39b8ba41-da7d-4c14-b842-7447f40d0173",
  "subject_name": "django/db/models/expressions::ColPairs.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

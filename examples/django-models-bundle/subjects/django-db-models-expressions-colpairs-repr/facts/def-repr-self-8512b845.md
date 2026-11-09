# Fact 8512b845

Store id: 85f17555-3f42-4774-8a1d-df45ebf3be3d

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:49.5624370+00:00`

## Data

```json
{
  "end_line": 1407,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1403,
  "symbol": "ColPairs.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1403,"selector":"L1403-L1407","symbol":"ColPairs.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1407,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1403,
    "symbol": "ColPairs.__repr__"
  },
  "id": "85f17555-3f42-4774-8a1d-df45ebf3be3d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5624370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1403,
        "selector": "L1403-L1407",
        "symbol": "ColPairs.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "398f638d-fcaf-4970-ba33-8dc1000cd112",
  "subject_name": "django/db/models/expressions::ColPairs.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```

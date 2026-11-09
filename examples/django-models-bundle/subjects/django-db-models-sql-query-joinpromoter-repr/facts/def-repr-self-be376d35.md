# Fact be376d35

Store id: 33751f58-3e74-4ec9-933f-ef85ae59d58d

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
- posted_at: `2026-11-09T22:39:51.5724670+00:00`

## Data

```json
{
  "end_line": 2833,
  "entity_kind": "method",
  "parent": "JoinPromoter",
  "start_line": 2829,
  "symbol": "JoinPromoter.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2829,"selector":"L2829-L2833","symbol":"JoinPromoter.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::JoinPromoter.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2833,
    "entity_kind": "method",
    "parent": "JoinPromoter",
    "start_line": 2829,
    "symbol": "JoinPromoter.__repr__"
  },
  "id": "33751f58-3e74-4ec9-933f-ef85ae59d58d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5724670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2829,
        "selector": "L2829-L2833",
        "symbol": "JoinPromoter.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "be94cff9-a4e9-4816-b23f-9c33fa052ae6",
  "subject_name": "django/db/models/sql/query::JoinPromoter.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```

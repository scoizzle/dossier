# Fact be376d35

Store id: 62dfd4a1-d02f-451b-b32a-aab0713625be

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
- posted_at: `2026-11-09T23:32:07.1719770+00:00`

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
  "id": "62dfd4a1-d02f-451b-b32a-aab0713625be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.1719770+00:00"
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
  "subject_id": "eeebc5fb-499c-45a4-b0f7-8842836ec1bc",
  "subject_name": "django/db/models/sql/query::JoinPromoter.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```

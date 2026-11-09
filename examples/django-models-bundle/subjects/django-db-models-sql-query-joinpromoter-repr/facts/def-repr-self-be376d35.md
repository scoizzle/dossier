# Fact be376d35

Store id: ae45805f-a990-438e-9542-c3e43fa28def

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
- posted_at: `2026-11-09T23:44:59.0800640+00:00`

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
  "id": "ae45805f-a990-438e-9542-c3e43fa28def",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0800640+00:00"
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
  "subject_id": "26c5180a-1c44-480a-8d3e-20d86128f943",
  "subject_name": "django/db/models/sql/query::JoinPromoter.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```

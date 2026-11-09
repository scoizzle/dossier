# Fact e3031e37

Store id: fdabfe79-6ce7-4e48-8c13-72870aebd642

## Text

```text
def __init__(self, connector, num_children, negated)
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
- posted_at: `2026-11-09T23:44:59.0748530+00:00`

## Data

```json
{
  "end_line": 2827,
  "entity_kind": "method",
  "parent": "JoinPromoter",
  "start_line": 2814,
  "symbol": "JoinPromoter.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2814,"selector":"L2814-L2827","symbol":"JoinPromoter.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::JoinPromoter.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2827,
    "entity_kind": "method",
    "parent": "JoinPromoter",
    "start_line": 2814,
    "symbol": "JoinPromoter.__init__"
  },
  "id": "fdabfe79-6ce7-4e48-8c13-72870aebd642",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0748530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2814,
        "selector": "L2814-L2827",
        "symbol": "JoinPromoter.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8137c772-59d5-40cc-95eb-2339c52d1712",
  "subject_name": "django/db/models/sql/query::JoinPromoter.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, connector, num_children, negated)"
}
```

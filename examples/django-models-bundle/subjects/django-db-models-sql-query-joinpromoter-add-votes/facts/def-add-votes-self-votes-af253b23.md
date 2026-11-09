# Fact af253b23

Store id: 46f8b44c-9f9d-4fc4-8a8a-a6cbe6951db2

## Text

```text
def add_votes(self, votes)
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
- posted_at: `2026-11-09T23:32:07.1763150+00:00`

## Data

```json
{
  "end_line": 2840,
  "entity_kind": "method",
  "parent": "JoinPromoter",
  "start_line": 2835,
  "symbol": "JoinPromoter.add_votes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2835,"selector":"L2835-L2840","symbol":"JoinPromoter.add_votes"}`

## Items

```json
[
  {
    "text": "Add single vote per item to self.votes. Parameter can be any iterable.",
    "locator": {
      "line": 2836
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::JoinPromoter.add_votes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2840,
    "entity_kind": "method",
    "parent": "JoinPromoter",
    "start_line": 2835,
    "symbol": "JoinPromoter.add_votes"
  },
  "id": "46f8b44c-9f9d-4fc4-8a8a-a6cbe6951db2",
  "items": [
    {
      "locator": {
        "line": 2836
      },
      "text": "Add single vote per item to self.votes. Parameter can be any iterable."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.1763150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2835,
        "selector": "L2835-L2840",
        "symbol": "JoinPromoter.add_votes"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4003dd98-6f07-4827-ad66-1f115471f75d",
  "subject_name": "django/db/models/sql/query::JoinPromoter.add_votes",
  "tags": [
    "entity:method"
  ],
  "text": "def add_votes(self, votes)"
}
```

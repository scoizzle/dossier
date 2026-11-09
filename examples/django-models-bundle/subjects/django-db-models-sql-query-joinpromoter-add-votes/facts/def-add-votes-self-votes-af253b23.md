# Fact af253b23

Store id: 5a1a5e58-4473-451b-b1ab-a8c90bc16f8e

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
- posted_at: `2026-11-09T22:39:51.5761910+00:00`

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
  "id": "5a1a5e58-4473-451b-b1ab-a8c90bc16f8e",
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
    "posted_at": "2026-11-09T22:39:51.5761910+00:00"
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
  "subject_id": "69282368-4c6d-43c8-87e3-11b17d17185e",
  "subject_name": "django/db/models/sql/query::JoinPromoter.add_votes",
  "tags": [
    "entity:method"
  ],
  "text": "def add_votes(self, votes)"
}
```

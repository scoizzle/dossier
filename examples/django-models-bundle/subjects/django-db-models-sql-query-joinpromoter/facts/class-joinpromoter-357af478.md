# Fact 357af478

Store id: 4021cc62-a168-45ec-95a4-cb5876f91ee7

## Text

```text
class JoinPromoter
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.5642550+00:00`

## Data

```json
{
  "end_line": 2897,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 2808,
  "symbol": "JoinPromoter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2808,"selector":"L2808-L2897","symbol":"JoinPromoter"}`

## Items

```json
[
  {
    "text": "A class to abstract away join promotion problems for complex filter conditions.",
    "locator": {
      "line": 2809
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::JoinPromoter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2897,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 2808,
    "symbol": "JoinPromoter"
  },
  "id": "4021cc62-a168-45ec-95a4-cb5876f91ee7",
  "items": [
    {
      "locator": {
        "line": 2809
      },
      "text": "A class to abstract away join promotion problems for complex filter conditions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5642550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2808,
        "selector": "L2808-L2897",
        "symbol": "JoinPromoter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "dd8e0b95-7764-471a-b8ff-4dca6eb27472",
  "subject_name": "django/db/models/sql/query::JoinPromoter",
  "tags": [
    "entity:class"
  ],
  "text": "class JoinPromoter"
}
```

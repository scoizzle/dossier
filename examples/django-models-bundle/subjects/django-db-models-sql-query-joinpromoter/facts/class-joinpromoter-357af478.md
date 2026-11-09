# Fact 357af478

Store id: db7afa8b-5346-44f4-8ee3-f1f93d5c9e5f

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
- posted_at: `2026-11-09T23:32:07.1626270+00:00`

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
  "id": "db7afa8b-5346-44f4-8ee3-f1f93d5c9e5f",
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
    "posted_at": "2026-11-09T23:32:07.1626270+00:00"
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
  "subject_id": "0b96122d-adc6-405b-94f3-fbb1b5459c01",
  "subject_name": "django/db/models/sql/query::JoinPromoter",
  "tags": [
    "entity:class"
  ],
  "text": "class JoinPromoter"
}
```

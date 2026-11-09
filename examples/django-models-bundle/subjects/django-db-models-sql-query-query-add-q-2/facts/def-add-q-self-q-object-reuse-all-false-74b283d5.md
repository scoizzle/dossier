# Fact 74b283d5

Store id: b26a9b14-dd62-4ca3-896c-c7963588f30e

## Text

```text
def add_q(self, q_object, reuse_all=False)
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
- posted_at: `2026-11-09T23:44:58.8544290+00:00`

## Data

```json
{
  "end_line": 1683,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1662,
  "symbol": "Query.add_q"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1662,"selector":"L1662-L1683","symbol":"Query.add_q"}`

## Items

```json
[
  {
    "text": "A preprocessor for the internal _add_q(). Responsible for doing final join promotion.",
    "locator": {
      "line": 1663
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_q](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1683,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1662,
    "symbol": "Query.add_q"
  },
  "id": "b26a9b14-dd62-4ca3-896c-c7963588f30e",
  "items": [
    {
      "locator": {
        "line": 1663
      },
      "text": "A preprocessor for the internal _add_q(). Responsible for doing final join promotion."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8544290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1662,
        "selector": "L1662-L1683",
        "symbol": "Query.add_q"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "312bdea8-cd53-49d3-a7a7-ceb886a1c59a",
  "subject_name": "django/db/models/sql/query::Query.add_q",
  "tags": [
    "entity:method"
  ],
  "text": "def add_q(self, q_object, reuse_all=False)"
}
```

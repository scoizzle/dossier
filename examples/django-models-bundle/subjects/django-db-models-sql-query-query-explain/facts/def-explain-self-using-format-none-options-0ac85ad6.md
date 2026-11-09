# Fact 0ac85ad6

Store id: a7d18009-3921-4445-bb11-7dc8b71d70cf

## Text

```text
def explain(self, using, format=None, **options)
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
- posted_at: `2026-11-09T23:44:58.6815000+00:00`

## Data

```json
{
  "end_line": 698,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 688,
  "symbol": "Query.explain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":688,"selector":"L688-L698","symbol":"Query.explain"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.explain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 698,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 688,
    "symbol": "Query.explain"
  },
  "id": "a7d18009-3921-4445-bb11-7dc8b71d70cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6815000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 688,
        "selector": "L688-L698",
        "symbol": "Query.explain"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c2707f4b-6fc4-40be-b726-fb5d878a90d4",
  "subject_name": "django/db/models/sql/query::Query.explain",
  "tags": [
    "entity:method"
  ],
  "text": "def explain(self, using, format=None, **options)"
}
```

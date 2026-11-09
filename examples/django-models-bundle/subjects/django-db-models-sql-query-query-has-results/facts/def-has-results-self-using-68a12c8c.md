# Fact 68a12c8c

Store id: 2de495c9-e624-4ef2-b07e-c1a8e8ee463a

## Text

```text
def has_results(self, using)
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
- posted_at: `2026-11-09T23:32:06.8086180+00:00`

## Data

```json
{
  "end_line": 686,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 683,
  "symbol": "Query.has_results"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":683,"selector":"L683-L686","symbol":"Query.has_results"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_results](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 686,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 683,
    "symbol": "Query.has_results"
  },
  "id": "2de495c9-e624-4ef2-b07e-c1a8e8ee463a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8086180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 683,
        "selector": "L683-L686",
        "symbol": "Query.has_results"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0cc0402a-ecd4-437b-8a16-c46d7b6210ab",
  "subject_name": "django/db/models/sql/query::Query.has_results",
  "tags": [
    "entity:method"
  ],
  "text": "def has_results(self, using)"
}
```

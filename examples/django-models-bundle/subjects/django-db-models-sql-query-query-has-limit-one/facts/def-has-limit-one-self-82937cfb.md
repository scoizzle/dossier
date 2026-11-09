# Fact 82937cfb

Store id: 29af9477-8005-4612-a2cd-b6ff7bda6509

## Text

```text
def has_limit_one(self)
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
- posted_at: `2026-11-09T22:39:51.4562320+00:00`

## Data

```json
{
  "end_line": 2221,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2220,
  "symbol": "Query.has_limit_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2220,"selector":"L2220-L2221","symbol":"Query.has_limit_one"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_limit_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2221,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2220,
    "symbol": "Query.has_limit_one"
  },
  "id": "29af9477-8005-4612-a2cd-b6ff7bda6509",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4562320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2220,
        "selector": "L2220-L2221",
        "symbol": "Query.has_limit_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "44707623-ac50-4989-b083-def6037d51d7",
  "subject_name": "django/db/models/sql/query::Query.has_limit_one",
  "tags": [
    "entity:method"
  ],
  "text": "def has_limit_one(self)"
}
```

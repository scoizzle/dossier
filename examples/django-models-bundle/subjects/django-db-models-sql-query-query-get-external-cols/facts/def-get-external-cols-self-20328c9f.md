# Fact 20328c9f

Store id: be0a3e08-cee8-4667-a6a3-7171a804a599

## Text

```text
def get_external_cols(self)
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
- posted_at: `2026-11-09T23:32:06.8982030+00:00`

## Data

```json
{
  "end_line": 1295,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1289,
  "symbol": "Query.get_external_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1289,"selector":"L1289-L1295","symbol":"Query.get_external_cols"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_external_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1295,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1289,
    "symbol": "Query.get_external_cols"
  },
  "id": "be0a3e08-cee8-4667-a6a3-7171a804a599",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8982030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1289,
        "selector": "L1289-L1295",
        "symbol": "Query.get_external_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ed0287bd-4e2c-4dad-8500-5b8391d0500d",
  "subject_name": "django/db/models/sql/query::Query.get_external_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_external_cols(self)"
}
```

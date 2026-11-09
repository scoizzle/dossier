# Fact 0abe84c4

Store id: 05f74987-8b6d-42ec-902f-ccac7679212e

## Text

```text
def add_select_col(self, col, name)
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
- posted_at: `2026-11-09T23:32:07.0493370+00:00`

## Data

```json
{
  "end_line": 2254,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2251,
  "symbol": "Query.add_select_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2251,"selector":"L2251-L2254","symbol":"Query.add_select_col"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_select_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2254,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2251,
    "symbol": "Query.add_select_col"
  },
  "id": "05f74987-8b6d-42ec-902f-ccac7679212e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0493370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2251,
        "selector": "L2251-L2254",
        "symbol": "Query.add_select_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8da973ec-adec-42fe-8e9a-ba978eaf60c9",
  "subject_name": "django/db/models/sql/query::Query.add_select_col",
  "tags": [
    "entity:method"
  ],
  "text": "def add_select_col(self, col, name)"
}
```

# Fact 15d627f2

Store id: 0eff66e8-1b2f-443a-b94f-c0070f76cbec

## Text

```text
def demote_joins(self, aliases)
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
- posted_at: `2026-11-09T23:44:58.7293760+00:00`

## Data

```json
{
  "end_line": 989,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 972,
  "symbol": "Query.demote_joins"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":972,"selector":"L972-L989","symbol":"Query.demote_joins"}`

## Items

```json
[
  {
    "text": "Change join type from LOUTER to INNER for all joins in aliases.",
    "locator": {
      "line": 973
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.demote_joins](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 989,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 972,
    "symbol": "Query.demote_joins"
  },
  "id": "0eff66e8-1b2f-443a-b94f-c0070f76cbec",
  "items": [
    {
      "locator": {
        "line": 973
      },
      "text": "Change join type from LOUTER to INNER for all joins in aliases."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.7293760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 972,
        "selector": "L972-L989",
        "symbol": "Query.demote_joins"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6fe2b90c-4f55-4884-b126-b9f6a8c9f2a4",
  "subject_name": "django/db/models/sql/query::Query.demote_joins",
  "tags": [
    "entity:method"
  ],
  "text": "def demote_joins(self, aliases)"
}
```

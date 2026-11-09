# Fact 6bf97bcb

Store id: 56625680-5456-434e-b673-1250b65db08a

## Text

```text
def table_alias(self, table_name, create=False, filtered_relation=None)
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
- posted_at: `2026-11-09T22:39:51.2870370+00:00`

## Data

```json
{
  "end_line": 924,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 899,
  "symbol": "Query.table_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":899,"selector":"L899-L924","symbol":"Query.table_alias"}`

## Items

```json
[
  {
    "text": "Return a table alias for the given table_name and whether this is a new alias or not.",
    "locator": {
      "line": 900
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.table_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 924,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 899,
    "symbol": "Query.table_alias"
  },
  "id": "56625680-5456-434e-b673-1250b65db08a",
  "items": [
    {
      "locator": {
        "line": 900
      },
      "text": "Return a table alias for the given table_name and whether this is a new alias or not."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2870370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 899,
        "selector": "L899-L924",
        "symbol": "Query.table_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "18295556-25db-406f-8368-20b6490c86dd",
  "subject_name": "django/db/models/sql/query::Query.table_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def table_alias(self, table_name, create=False, filtered_relation=None)"
}
```

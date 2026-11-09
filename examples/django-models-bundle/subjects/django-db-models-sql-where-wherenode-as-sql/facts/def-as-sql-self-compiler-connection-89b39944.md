# Fact 89b39944

Store id: df99e767-1a92-47e1-ae0e-34cf34ec19e7

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:07.5860910+00:00`

## Data

```json
{
  "end_line": 188,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 116,
  "symbol": "WhereNode.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":116,"selector":"L116-L188","symbol":"WhereNode.as_sql"}`

## Items

```json
[
  {
    "text": "Return the SQL version of the where clause and the value to be substituted in. Return '', [] if this node matches everything, None, [] if this node is empty, and raise EmptyResultSet if this node can't match anything.",
    "locator": {
      "line": 117
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 188,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 116,
    "symbol": "WhereNode.as_sql"
  },
  "id": "df99e767-1a92-47e1-ae0e-34cf34ec19e7",
  "items": [
    {
      "locator": {
        "line": 117
      },
      "text": "Return the SQL version of the where clause and the value to be substituted in. Return '', [] if this node matches everything, None, [] if this node is empty, and raise EmptyResultSet if this node can't match anything."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.5860910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 116,
        "selector": "L116-L188",
        "symbol": "WhereNode.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "2fc5434c-0feb-4dd8-81d9-b1985fde0354",
  "subject_name": "django/db/models/sql/where::WhereNode.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```

# Fact 89b39944

Store id: c6fb3c85-d534-487b-b83c-d90b4d54e5c6

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
- posted_at: `2026-11-09T23:44:59.6864040+00:00`

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
  "id": "c6fb3c85-d534-487b-b83c-d90b4d54e5c6",
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
    "posted_at": "2026-11-09T23:44:59.6864040+00:00"
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
  "subject_id": "e602b317-910b-4399-b1fa-f36591fb5e9e",
  "subject_name": "django/db/models/sql/where::WhereNode.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```

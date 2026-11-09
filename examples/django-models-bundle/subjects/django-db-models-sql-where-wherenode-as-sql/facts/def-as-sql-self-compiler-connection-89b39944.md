# Fact 89b39944

Store id: 9eb76436-6413-4732-a40f-bf44ca5a3c10

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
- posted_at: `2026-11-09T22:39:51.8982160+00:00`

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
  "id": "9eb76436-6413-4732-a40f-bf44ca5a3c10",
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
    "posted_at": "2026-11-09T22:39:51.8982160+00:00"
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
  "subject_id": "18eb2ef2-8398-472a-ae5c-827acb1e8e9c",
  "subject_name": "django/db/models/sql/where::WhereNode.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```

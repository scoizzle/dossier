# Fact 0c711581

Store id: ca604e51-b84c-4e99-957d-13c8c1114394

## Text

```text
def as_sql(self, compiler=None, connection=None)
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
- posted_at: `2026-11-09T23:32:07.7103580+00:00`

## Data

```json
{
  "end_line": 331,
  "entity_kind": "method",
  "parent": "NothingNode",
  "start_line": 330,
  "symbol": "NothingNode.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":330,"selector":"L330-L331","symbol":"NothingNode.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::NothingNode.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 331,
    "entity_kind": "method",
    "parent": "NothingNode",
    "start_line": 330,
    "symbol": "NothingNode.as_sql"
  },
  "id": "ca604e51-b84c-4e99-957d-13c8c1114394",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.7103580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 330,
        "selector": "L330-L331",
        "symbol": "NothingNode.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "be70589f-d6c3-4b44-9f50-dbdb8c4a296a",
  "subject_name": "django/db/models/sql/where::NothingNode.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler=None, connection=None)"
}
```

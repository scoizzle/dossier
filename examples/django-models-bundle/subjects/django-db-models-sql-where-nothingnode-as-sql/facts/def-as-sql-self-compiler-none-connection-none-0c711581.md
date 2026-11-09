# Fact 0c711581

Store id: ce25e7b8-9426-49aa-8121-50a325e7ce9d

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
- posted_at: `2026-11-09T22:39:51.9855140+00:00`

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
  "id": "ce25e7b8-9426-49aa-8121-50a325e7ce9d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9855140+00:00"
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
  "subject_id": "8d294ef7-b853-408e-86e2-e713746cd660",
  "subject_name": "django/db/models/sql/where::NothingNode.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler=None, connection=None)"
}
```

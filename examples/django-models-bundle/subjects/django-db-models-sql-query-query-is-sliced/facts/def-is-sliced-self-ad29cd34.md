# Fact ad29cd34

Store id: 8131501a-c51d-4d21-b67c-f1b00e302d7b

## Text

```text
def is_sliced(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:58.9417030+00:00`

## Data

```json
{
  "end_line": 2218,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2216,
  "symbol": "Query.is_sliced"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2216,"selector":"L2216-L2218","symbol":"Query.is_sliced"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.is_sliced](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2218,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2216,
    "symbol": "Query.is_sliced"
  },
  "id": "8131501a-c51d-4d21-b67c-f1b00e302d7b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9417030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2216,
        "selector": "L2216-L2218",
        "symbol": "Query.is_sliced"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0062969b-d729-42e5-a305-a410d89f0e50",
  "subject_name": "django/db/models/sql/query::Query.is_sliced",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_sliced(self)"
}
```

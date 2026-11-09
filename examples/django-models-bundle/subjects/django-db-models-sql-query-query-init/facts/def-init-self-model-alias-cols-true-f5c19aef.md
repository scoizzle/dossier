# Fact f5c19aef

Store id: a574cd80-7b16-4cad-8c24-9c71b37d5f75

## Text

```text
def __init__(self, model, alias_cols=True)
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
- posted_at: `2026-11-09T23:32:06.7474590+00:00`

## Data

```json
{
  "end_line": 330,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 305,
  "symbol": "Query.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":305,"selector":"L305-L330","symbol":"Query.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 330,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 305,
    "symbol": "Query.__init__"
  },
  "id": "a574cd80-7b16-4cad-8c24-9c71b37d5f75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7474590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 305,
        "selector": "L305-L330",
        "symbol": "Query.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "40f811d1-bfec-4ec3-870d-5dd202708a2d",
  "subject_name": "django/db/models/sql/query::Query.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model, alias_cols=True)"
}
```

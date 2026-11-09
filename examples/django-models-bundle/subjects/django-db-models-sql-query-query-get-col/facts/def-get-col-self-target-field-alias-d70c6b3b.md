# Fact d70c6b3b

Store id: 07bb2a5a-1511-4aea-8215-e4675b16c7a8

## Text

```text
def _get_col(self, target, field, alias)
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
- posted_at: `2026-11-09T23:44:58.6478590+00:00`

## Data

```json
{
  "end_line": 455,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 452,
  "symbol": "Query._get_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":452,"selector":"L452-L455","symbol":"Query._get_col"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._get_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 455,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 452,
    "symbol": "Query._get_col"
  },
  "id": "07bb2a5a-1511-4aea-8215-e4675b16c7a8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6478590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 452,
        "selector": "L452-L455",
        "symbol": "Query._get_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8723aa1e-e250-4354-a7c0-a161891c9dad",
  "subject_name": "django/db/models/sql/query::Query._get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_col(self, target, field, alias)"
}
```

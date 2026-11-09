# Fact d70c6b3b

Store id: 4791df31-55ac-4d9d-96e1-e4064449cf5b

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
- posted_at: `2026-11-09T23:32:06.7888140+00:00`

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
  "id": "4791df31-55ac-4d9d-96e1-e4064449cf5b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7888140+00:00"
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
  "subject_id": "d6205c47-bc4d-4bb9-aa9f-1489bbd9844c",
  "subject_name": "django/db/models/sql/query::Query._get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_col(self, target, field, alias)"
}
```

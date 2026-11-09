# Fact 388f8991

Store id: 716792b2-434c-4718-9de0-e9540312317a

## Text

```text
def relabeled_clone(self, change_map)
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
- posted_at: `2026-11-09T23:44:58.6425030+00:00`

## Data

```json
{
  "end_line": 450,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 447,
  "symbol": "Query.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":447,"selector":"L447-L450","symbol":"Query.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 450,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 447,
    "symbol": "Query.relabeled_clone"
  },
  "id": "716792b2-434c-4718-9de0-e9540312317a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6425030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 447,
        "selector": "L447-L450",
        "symbol": "Query.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8f29d33a-1660-4875-b18b-9148c07022dd",
  "subject_name": "django/db/models/sql/query::Query.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```

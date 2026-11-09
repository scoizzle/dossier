# Fact 388f8991

Store id: f338ec33-828a-4b03-bfe8-84e7698a1143

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
- posted_at: `2026-11-09T23:32:06.7851700+00:00`

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
  "id": "f338ec33-828a-4b03-bfe8-84e7698a1143",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7851700+00:00"
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
  "subject_id": "8ab8d38a-2734-4008-98c3-a101de38a688",
  "subject_name": "django/db/models/sql/query::Query.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```

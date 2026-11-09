# Fact 498d91e4

Store id: 98c373d7-5612-4ee2-bb88-f6878d210e92

## Text

```text
def _check_bulk_create_options( self, ignore_conflicts, update_conflicts, update_fields, unique_fields )
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
- posted_at: `2026-11-09T23:32:04.4004690+00:00`

## Data

```json
{
  "end_line": 831,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 779,
  "symbol": "QuerySet._check_bulk_create_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":779,"selector":"L779-L831","symbol":"QuerySet._check_bulk_create_options"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._check_bulk_create_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 831,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 779,
    "symbol": "QuerySet._check_bulk_create_options"
  },
  "id": "98c373d7-5612-4ee2-bb88-f6878d210e92",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4004690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 779,
        "selector": "L779-L831",
        "symbol": "QuerySet._check_bulk_create_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "197a5f6b-5eeb-4da0-a627-7801a6b39a64",
  "subject_name": "django/db/models/query::QuerySet._check_bulk_create_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_bulk_create_options( self, ignore_conflicts, update_conflicts, update_fields, unique_fields )"
}
```

# Fact 012a604f

Store id: 43eddeb7-d352-45d0-8205-ff018f6ce751

## Text

```text
def update_batch(self, pk_list, values, using)
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
- posted_at: `2026-11-09T22:39:51.7406500+00:00`

## Data

```json
{
  "end_line": 79,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 72,
  "symbol": "UpdateQuery.update_batch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":72,"selector":"L72-L79","symbol":"UpdateQuery.update_batch"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery.update_batch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 79,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 72,
    "symbol": "UpdateQuery.update_batch"
  },
  "id": "43eddeb7-d352-45d0-8205-ff018f6ce751",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7406500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 72,
        "selector": "L72-L79",
        "symbol": "UpdateQuery.update_batch"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "0ba14052-4a7d-4a64-93b3-599914b04baf",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.update_batch",
  "tags": [
    "entity:method"
  ],
  "text": "def update_batch(self, pk_list, values, using)"
}
```

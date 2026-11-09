# Fact 012a604f

Store id: ae4e6b2a-2643-43b1-9a2e-7ad647c887e3

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
- posted_at: `2026-11-09T23:32:07.3813250+00:00`

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
  "id": "ae4e6b2a-2643-43b1-9a2e-7ad647c887e3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.3813250+00:00"
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
  "subject_id": "35c93f97-ac9c-4514-994a-714fe04a4fe9",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.update_batch",
  "tags": [
    "entity:method"
  ],
  "text": "def update_batch(self, pk_list, values, using)"
}
```

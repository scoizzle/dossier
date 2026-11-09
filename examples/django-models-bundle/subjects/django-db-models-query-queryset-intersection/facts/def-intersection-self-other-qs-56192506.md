# Fact 56192506

Store id: 3ea3f510-147f-4bac-936a-93164734d5ef

## Text

```text
def intersection(self, *other_qs)
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
- posted_at: `2026-11-09T23:32:04.5615360+00:00`

## Data

```json
{
  "end_line": 1780,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1773,
  "symbol": "QuerySet.intersection"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1773,"selector":"L1773-L1780","symbol":"QuerySet.intersection"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.intersection](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1780,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1773,
    "symbol": "QuerySet.intersection"
  },
  "id": "3ea3f510-147f-4bac-936a-93164734d5ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5615360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1773,
        "selector": "L1773-L1780",
        "symbol": "QuerySet.intersection"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "39094145-7e98-4c33-8208-1432da891059",
  "subject_name": "django/db/models/query::QuerySet.intersection",
  "tags": [
    "entity:method"
  ],
  "text": "def intersection(self, *other_qs)"
}
```

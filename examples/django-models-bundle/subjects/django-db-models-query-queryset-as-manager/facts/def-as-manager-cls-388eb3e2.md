# Fact 388eb3e2

Store id: 0797f82c-cab5-4299-8150-f4e9c6253ecd

## Text

```text
def as_manager(cls)
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
- posted_at: `2026-11-09T22:39:49.2986370+00:00`

## Data

```json
{
  "end_line": 405,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 399,
  "symbol": "QuerySet.as_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":399,"selector":"L399-L405","symbol":"QuerySet.as_manager"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.as_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 405,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 399,
    "symbol": "QuerySet.as_manager"
  },
  "id": "0797f82c-cab5-4299-8150-f4e9c6253ecd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2986370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 399,
        "selector": "L399-L405",
        "symbol": "QuerySet.as_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "86c43339-b57a-44b1-8782-f4687f91b8a8",
  "subject_name": "django/db/models/query::QuerySet.as_manager",
  "tags": [
    "entity:method"
  ],
  "text": "def as_manager(cls)"
}
```

# Fact f133da1a

Store id: d23f2690-c5d1-48ab-a651-98f14c705f02

## Text

```text
def __or__(self, other)
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
- posted_at: `2026-11-09T22:39:49.3504610+00:00`

## Data

```json
{
  "end_line": 559,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 542,
  "symbol": "QuerySet.__or__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":542,"selector":"L542-L559","symbol":"QuerySet.__or__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__or__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 559,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 542,
    "symbol": "QuerySet.__or__"
  },
  "id": "d23f2690-c5d1-48ab-a651-98f14c705f02",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3504610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 542,
        "selector": "L542-L559",
        "symbol": "QuerySet.__or__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "bc73a13a-4398-457f-98fc-9eb606d2a55e",
  "subject_name": "django/db/models/query::QuerySet.__or__",
  "tags": [
    "entity:method"
  ],
  "text": "def __or__(self, other)"
}
```

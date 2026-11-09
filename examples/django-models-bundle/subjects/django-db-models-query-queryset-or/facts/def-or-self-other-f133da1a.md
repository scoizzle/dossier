# Fact f133da1a

Store id: a887ea3e-2608-45e4-8dea-0aa16c9d0e47

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
- posted_at: `2026-11-09T23:44:55.8706330+00:00`

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
  "id": "a887ea3e-2608-45e4-8dea-0aa16c9d0e47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8706330+00:00"
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
  "subject_id": "a74ab8f0-39ef-4bec-9434-e670bdf00308",
  "subject_name": "django/db/models/query::QuerySet.__or__",
  "tags": [
    "entity:method"
  ],
  "text": "def __or__(self, other)"
}
```

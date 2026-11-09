# Fact f133da1a

Store id: 1d2c5cd3-1e18-4567-9a1a-89c39db049e8

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
- posted_at: `2026-11-09T23:32:04.3542470+00:00`

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
  "id": "1d2c5cd3-1e18-4567-9a1a-89c39db049e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3542470+00:00"
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
  "subject_id": "a4c34a97-e805-49a6-97cf-5ced71d85ce5",
  "subject_name": "django/db/models/query::QuerySet.__or__",
  "tags": [
    "entity:method"
  ],
  "text": "def __or__(self, other)"
}
```

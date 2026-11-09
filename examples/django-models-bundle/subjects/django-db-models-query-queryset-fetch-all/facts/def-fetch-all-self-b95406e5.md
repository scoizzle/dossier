# Fact b95406e5

Store id: 7a466ba6-866f-4068-8191-d589aa1b1480

## Text

```text
def _fetch_all(self)
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
- posted_at: `2026-11-09T23:44:56.1577810+00:00`

## Data

```json
{
  "end_line": 2289,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2285,
  "symbol": "QuerySet._fetch_all"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2285,"selector":"L2285-L2289","symbol":"QuerySet._fetch_all"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._fetch_all](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2289,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2285,
    "symbol": "QuerySet._fetch_all"
  },
  "id": "7a466ba6-866f-4068-8191-d589aa1b1480",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1577810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2285,
        "selector": "L2285-L2289",
        "symbol": "QuerySet._fetch_all"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a29d639f-4ae9-45bc-8b75-b4488051ae08",
  "subject_name": "django/db/models/query::QuerySet._fetch_all",
  "tags": [
    "entity:method"
  ],
  "text": "def _fetch_all(self)"
}
```

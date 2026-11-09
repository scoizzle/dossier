# Fact 2db7cc87

Store id: befc3f28-782e-47bc-a9a5-a615a41ccd4c

## Text

```text
def set_select(self, cols)
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
- posted_at: `2026-11-09T22:39:51.4756820+00:00`

## Data

```json
{
  "end_line": 2258,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2256,
  "symbol": "Query.set_select"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2256,"selector":"L2256-L2258","symbol":"Query.set_select"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_select](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2258,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2256,
    "symbol": "Query.set_select"
  },
  "id": "befc3f28-782e-47bc-a9a5-a615a41ccd4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4756820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2256,
        "selector": "L2256-L2258",
        "symbol": "Query.set_select"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c575b307-fefc-4471-940b-24d8dc30416d",
  "subject_name": "django/db/models/sql/query::Query.set_select",
  "tags": [
    "entity:method"
  ],
  "text": "def set_select(self, cols)"
}
```

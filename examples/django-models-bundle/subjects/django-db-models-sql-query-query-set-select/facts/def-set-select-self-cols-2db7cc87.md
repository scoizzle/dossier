# Fact 2db7cc87

Store id: 93446bd7-b257-47aa-838f-0144f2e2c889

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
- posted_at: `2026-11-09T23:44:58.9693620+00:00`

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
  "id": "93446bd7-b257-47aa-838f-0144f2e2c889",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9693620+00:00"
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
  "subject_id": "c0afb839-fe2d-407a-ae0e-efa6345c289c",
  "subject_name": "django/db/models/sql/query::Query.set_select",
  "tags": [
    "entity:method"
  ],
  "text": "def set_select(self, cols)"
}
```

# Fact c828d21a

Store id: 2c55c433-ad01-4b17-9afc-0fba253b6dfa

## Text

```text
def resolve_lookup_value(self, value, can_reuse, allow_joins, summarize=False)
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
- posted_at: `2026-11-09T22:39:51.3510160+00:00`

## Data

```json
{
  "end_line": 1341,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1322,
  "symbol": "Query.resolve_lookup_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1322,"selector":"L1322-L1341","symbol":"Query.resolve_lookup_value"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.resolve_lookup_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1341,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1322,
    "symbol": "Query.resolve_lookup_value"
  },
  "id": "2c55c433-ad01-4b17-9afc-0fba253b6dfa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3510160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1322,
        "selector": "L1322-L1341",
        "symbol": "Query.resolve_lookup_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b8bfaca5-1ca5-4b8a-8ad9-ff7536aa0fcc",
  "subject_name": "django/db/models/sql/query::Query.resolve_lookup_value",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_lookup_value(self, value, can_reuse, allow_joins, summarize=False)"
}
```

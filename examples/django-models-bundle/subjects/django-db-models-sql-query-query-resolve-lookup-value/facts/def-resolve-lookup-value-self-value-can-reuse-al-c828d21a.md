# Fact c828d21a

Store id: 17c4159f-25f4-4321-869c-28e8b1a3f520

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
- posted_at: `2026-11-09T23:32:06.9095810+00:00`

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
  "id": "17c4159f-25f4-4321-869c-28e8b1a3f520",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9095810+00:00"
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
  "subject_id": "640078fe-4eee-41a8-a82f-d663852457a6",
  "subject_name": "django/db/models/sql/query::Query.resolve_lookup_value",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_lookup_value(self, value, can_reuse, allow_joins, summarize=False)"
}
```

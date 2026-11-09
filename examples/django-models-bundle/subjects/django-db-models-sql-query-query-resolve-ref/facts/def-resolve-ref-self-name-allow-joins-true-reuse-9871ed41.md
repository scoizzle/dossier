# Fact 9871ed41

Store id: e8b8b6f1-2ea9-4e4a-909c-336ac3f16509

## Text

```text
def resolve_ref(self, name, allow_joins=True, reuse=None, summarize=False)
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
- posted_at: `2026-11-09T23:32:06.9959670+00:00`

## Data

```json
{
  "end_line": 2110,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2061,
  "symbol": "Query.resolve_ref"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2061,"selector":"L2061-L2110","symbol":"Query.resolve_ref"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.resolve_ref](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2110,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2061,
    "symbol": "Query.resolve_ref"
  },
  "id": "e8b8b6f1-2ea9-4e4a-909c-336ac3f16509",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9959670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2061,
        "selector": "L2061-L2110",
        "symbol": "Query.resolve_ref"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d3e00fec-1df3-4f92-8bf8-2a4f8a4b7db9",
  "subject_name": "django/db/models/sql/query::Query.resolve_ref",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_ref(self, name, allow_joins=True, reuse=None, summarize=False)"
}
```

# Fact 9871ed41

Store id: e4a35874-b0a9-42c8-951d-a5f4a4871543

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
- posted_at: `2026-11-09T22:39:51.4270840+00:00`

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
  "id": "e4a35874-b0a9-42c8-951d-a5f4a4871543",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4270840+00:00"
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
  "subject_id": "4b30cf1d-4613-4bbf-89de-5e20e3a390c0",
  "subject_name": "django/db/models/sql/query::Query.resolve_ref",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_ref(self, name, allow_joins=True, reuse=None, summarize=False)"
}
```

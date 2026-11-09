# Fact 8711cfce

Store id: 1ea38ca1-1292-412e-bb10-e31938554953

## Text

```text
def prefix_gen()
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.3120860+00:00`

## Data

```json
{
  "end_line": 1081,
  "entity_kind": "function",
  "parent": "Query.bump_prefix",
  "start_line": 1065,
  "symbol": "Query.bump_prefix.prefix_gen"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1065,"selector":"L1065-L1081","symbol":"Query.bump_prefix.prefix_gen"}`

## Items

```json
[
  {
    "text": "Generate a sequence of characters in alphabetical order: -> 'A', 'B', 'C', ...",
    "locator": {
      "line": 1066
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.bump_prefix.prefix_gen](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1081,
    "entity_kind": "function",
    "parent": "Query.bump_prefix",
    "start_line": 1065,
    "symbol": "Query.bump_prefix.prefix_gen"
  },
  "id": "1ea38ca1-1292-412e-bb10-e31938554953",
  "items": [
    {
      "locator": {
        "line": 1066
      },
      "text": "Generate a sequence of characters in alphabetical order: -> 'A', 'B', 'C', ..."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3120860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1065,
        "selector": "L1065-L1081",
        "symbol": "Query.bump_prefix.prefix_gen"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2b058623-b3d0-4dae-bf4e-b936b48d2817",
  "subject_name": "django/db/models/sql/query::Query.bump_prefix.prefix_gen",
  "tags": [
    "entity:function"
  ],
  "text": "def prefix_gen()"
}
```

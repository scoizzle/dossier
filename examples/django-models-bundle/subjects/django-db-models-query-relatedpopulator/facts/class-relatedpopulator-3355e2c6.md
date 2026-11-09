# Fact 3355e2c6

Store id: f58122e4-8efc-4f67-94a9-b383f73ca9a5

## Text

```text
class RelatedPopulator
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.9016760+00:00`

## Data

```json
{
  "end_line": 3087,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 2984,
  "symbol": "RelatedPopulator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2984,"selector":"L2984-L3087","symbol":"RelatedPopulator"}`

## Items

```json
[
  {
    "text": "RelatedPopulator is used for select_related() object instantiation.",
    "locator": {
      "line": 2985
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RelatedPopulator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 3087,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 2984,
    "symbol": "RelatedPopulator"
  },
  "id": "f58122e4-8efc-4f67-94a9-b383f73ca9a5",
  "items": [
    {
      "locator": {
        "line": 2985
      },
      "text": "RelatedPopulator is used for select_related() object instantiation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.9016760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2984,
        "selector": "L2984-L3087",
        "symbol": "RelatedPopulator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8975b2c7-1536-42ea-9eec-83801619877d",
  "subject_name": "django/db/models/query::RelatedPopulator",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedPopulator"
}
```

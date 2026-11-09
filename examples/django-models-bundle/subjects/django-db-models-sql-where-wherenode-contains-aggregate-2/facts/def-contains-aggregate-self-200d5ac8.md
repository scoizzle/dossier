# Fact 200d5ac8

Store id: de9856dc-1186-459a-a4ed-ffcdc3904b1e

## Text

```text
def contains_aggregate(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:59.7594610+00:00`

## Data

```json
{
  "end_line": 254,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 252,
  "symbol": "WhereNode.contains_aggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":252,"selector":"L252-L254","symbol":"WhereNode.contains_aggregate"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.contains_aggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 254,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 252,
    "symbol": "WhereNode.contains_aggregate"
  },
  "id": "de9856dc-1186-459a-a4ed-ffcdc3904b1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7594610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 252,
        "selector": "L252-L254",
        "symbol": "WhereNode.contains_aggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "9828e5fa-82e5-4ed6-a646-269ddc711767",
  "subject_name": "django/db/models/sql/where::WhereNode.contains_aggregate",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_aggregate(self)"
}
```

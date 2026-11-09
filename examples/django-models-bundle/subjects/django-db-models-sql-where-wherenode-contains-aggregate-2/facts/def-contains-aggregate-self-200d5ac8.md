# Fact 200d5ac8

Store id: 0390b792-e036-4d5c-bd70-cc8bd338b387

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
- posted_at: `2026-11-09T22:39:51.9402900+00:00`

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
  "id": "0390b792-e036-4d5c-bd70-cc8bd338b387",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9402900+00:00"
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
  "subject_id": "e8d10e55-180e-4692-bf0c-bb299975caf2",
  "subject_name": "django/db/models/sql/where::WhereNode.contains_aggregate",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_aggregate(self)"
}
```

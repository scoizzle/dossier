# Fact 4287b1e7

Store id: 001739e5-be9f-4e72-a515-33a3fc481b9e

## Text

```text
class WhereNode(tree.Node)
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
- posted_at: `2026-11-09T23:32:07.5603120+00:00`

## Data

```json
{
  "end_line": 321,
  "entity_kind": "class",
  "parent": "where",
  "start_line": 21,
  "symbol": "WhereNode"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":21,"selector":"L21-L321","symbol":"WhereNode"}`

## Items

```json
[
  {
    "text": "An SQL WHERE clause.",
    "locator": {
      "line": 22
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 321,
    "entity_kind": "class",
    "parent": "where",
    "start_line": 21,
    "symbol": "WhereNode"
  },
  "id": "001739e5-be9f-4e72-a515-33a3fc481b9e",
  "items": [
    {
      "locator": {
        "line": 22
      },
      "text": "An SQL WHERE clause."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.5603120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 21,
        "selector": "L21-L321",
        "symbol": "WhereNode"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "ea288970-4ff6-472d-bb88-cb5179ab8bf4",
  "subject_name": "django/db/models/sql/where::WhereNode",
  "tags": [
    "entity:class"
  ],
  "text": "class WhereNode(tree.Node)"
}
```

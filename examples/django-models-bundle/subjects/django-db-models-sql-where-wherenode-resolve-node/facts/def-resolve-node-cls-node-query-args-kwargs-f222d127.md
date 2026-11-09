# Fact f222d127

Store id: e5ec234f-73ff-46e2-acfe-682eb171cae2

## Text

```text
def _resolve_node(cls, node, query, *args, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.9553920+00:00`

## Data

```json
{
  "end_line": 284,
  "entity_kind": "class_method",
  "parent": "WhereNode",
  "start_line": 276,
  "symbol": "WhereNode._resolve_node"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":276,"selector":"L276-L284","symbol":"WhereNode._resolve_node"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode._resolve_node](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 284,
    "entity_kind": "class_method",
    "parent": "WhereNode",
    "start_line": 276,
    "symbol": "WhereNode._resolve_node"
  },
  "id": "e5ec234f-73ff-46e2-acfe-682eb171cae2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9553920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 276,
        "selector": "L276-L284",
        "symbol": "WhereNode._resolve_node"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "a0420fb2-c91c-41ca-b047-12c73e6cfcbc",
  "subject_name": "django/db/models/sql/where::WhereNode._resolve_node",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _resolve_node(cls, node, query, *args, **kwargs)"
}
```

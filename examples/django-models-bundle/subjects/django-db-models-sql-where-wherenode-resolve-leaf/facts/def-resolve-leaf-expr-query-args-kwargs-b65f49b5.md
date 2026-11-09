# Fact b65f49b5

Store id: 0b30913c-f9f1-434e-a6d3-3e55fc5499a0

## Text

```text
def _resolve_leaf(expr, query, *args, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:static_method`, `decorator:staticmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.6641840+00:00`

## Data

```json
{
  "end_line": 274,
  "entity_kind": "static_method",
  "parent": "WhereNode",
  "start_line": 270,
  "symbol": "WhereNode._resolve_leaf"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":270,"selector":"L270-L274","symbol":"WhereNode._resolve_leaf"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode._resolve_leaf](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 274,
    "entity_kind": "static_method",
    "parent": "WhereNode",
    "start_line": 270,
    "symbol": "WhereNode._resolve_leaf"
  },
  "id": "0b30913c-f9f1-434e-a6d3-3e55fc5499a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6641840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 270,
        "selector": "L270-L274",
        "symbol": "WhereNode._resolve_leaf"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "bf31df1b-c8c7-4062-83b3-ac42c38a74da",
  "subject_name": "django/db/models/sql/where::WhereNode._resolve_leaf",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _resolve_leaf(expr, query, *args, **kwargs)"
}
```

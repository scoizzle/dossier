# Fact b65f49b5

Store id: d68d59fa-713f-4c6f-83fe-182639f529d5

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
- posted_at: `2026-11-09T23:44:59.7785250+00:00`

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
  "id": "d68d59fa-713f-4c6f-83fe-182639f529d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7785250+00:00"
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
  "subject_id": "43146fb5-7d08-41d6-886e-4427a81da783",
  "subject_name": "django/db/models/sql/where::WhereNode._resolve_leaf",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _resolve_leaf(expr, query, *args, **kwargs)"
}
```

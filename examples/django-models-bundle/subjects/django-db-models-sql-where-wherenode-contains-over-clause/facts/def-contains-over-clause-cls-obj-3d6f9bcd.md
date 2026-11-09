# Fact 3d6f9bcd

Store id: 459519a1-2159-452f-aed7-933cd4368f1d

## Text

```text
def _contains_over_clause(cls, obj)
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
- posted_at: `2026-11-09T22:39:51.9432860+00:00`

## Data

```json
{
  "end_line": 260,
  "entity_kind": "class_method",
  "parent": "WhereNode",
  "start_line": 256,
  "symbol": "WhereNode._contains_over_clause"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":256,"selector":"L256-L260","symbol":"WhereNode._contains_over_clause"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode._contains_over_clause](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 260,
    "entity_kind": "class_method",
    "parent": "WhereNode",
    "start_line": 256,
    "symbol": "WhereNode._contains_over_clause"
  },
  "id": "459519a1-2159-452f-aed7-933cd4368f1d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9432860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 256,
        "selector": "L256-L260",
        "symbol": "WhereNode._contains_over_clause"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "abd996f7-1b1f-403f-a305-b17829849ba9",
  "subject_name": "django/db/models/sql/where::WhereNode._contains_over_clause",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _contains_over_clause(cls, obj)"
}
```

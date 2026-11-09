# Fact eaf26f07

Store id: bf3879f5-f516-4d07-bdc1-dbf59eb67a0f

## Text

```text
def resolve_expression(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:59.7901520+00:00`

## Data

```json
{
  "end_line": 290,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 286,
  "symbol": "WhereNode.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":286,"selector":"L286-L290","symbol":"WhereNode.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 290,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 286,
    "symbol": "WhereNode.resolve_expression"
  },
  "id": "bf3879f5-f516-4d07-bdc1-dbf59eb67a0f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7901520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 286,
        "selector": "L286-L290",
        "symbol": "WhereNode.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "664281d3-1801-40d4-b03a-706b55325045",
  "subject_name": "django/db/models/sql/where::WhereNode.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```

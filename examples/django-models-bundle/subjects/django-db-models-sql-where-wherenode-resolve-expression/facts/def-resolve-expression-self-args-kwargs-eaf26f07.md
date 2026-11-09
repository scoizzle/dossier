# Fact eaf26f07

Store id: b25c556b-66ce-4a9b-88f3-658608399817

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
- posted_at: `2026-11-09T23:32:07.6754160+00:00`

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
  "id": "b25c556b-66ce-4a9b-88f3-658608399817",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6754160+00:00"
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
  "subject_id": "38d17e6c-8338-4aed-89dc-bdc86e10e402",
  "subject_name": "django/db/models/sql/where::WhereNode.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```

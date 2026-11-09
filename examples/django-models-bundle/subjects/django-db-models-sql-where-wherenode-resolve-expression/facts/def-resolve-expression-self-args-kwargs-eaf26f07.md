# Fact eaf26f07

Store id: 1a1b593b-cd0f-45c7-9d7e-30c822710982

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
- posted_at: `2026-11-09T22:39:51.9591320+00:00`

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
  "id": "1a1b593b-cd0f-45c7-9d7e-30c822710982",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9591320+00:00"
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
  "subject_id": "cbae3abc-26f0-439c-804f-48452545daa4",
  "subject_name": "django/db/models/sql/where::WhereNode.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```

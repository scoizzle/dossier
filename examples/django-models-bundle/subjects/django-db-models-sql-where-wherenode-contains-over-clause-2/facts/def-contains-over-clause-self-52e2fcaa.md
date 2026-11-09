# Fact 52e2fcaa

Store id: 669d966e-49d7-4a0a-9558-fc7ab3318a8a

## Text

```text
def contains_over_clause(self)
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
- posted_at: `2026-11-09T23:44:59.7687870+00:00`

## Data

```json
{
  "end_line": 264,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 262,
  "symbol": "WhereNode.contains_over_clause"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":262,"selector":"L262-L264","symbol":"WhereNode.contains_over_clause"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.contains_over_clause](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 264,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 262,
    "symbol": "WhereNode.contains_over_clause"
  },
  "id": "669d966e-49d7-4a0a-9558-fc7ab3318a8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7687870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 262,
        "selector": "L262-L264",
        "symbol": "WhereNode.contains_over_clause"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "b4cfc1c3-fd86-4687-9413-a1266da3a0bb",
  "subject_name": "django/db/models/sql/where::WhereNode.contains_over_clause",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_over_clause(self)"
}
```

# Fact 52e2fcaa

Store id: c2c52c7e-7b94-4fa3-8a04-3051d766c1ec

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
- posted_at: `2026-11-09T23:32:07.6558750+00:00`

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
  "id": "c2c52c7e-7b94-4fa3-8a04-3051d766c1ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6558750+00:00"
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
  "subject_id": "46503c96-2522-43dc-b002-7b03101ee462",
  "subject_name": "django/db/models/sql/where::WhereNode.contains_over_clause",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_over_clause(self)"
}
```

# Fact 2e9ba87a

Store id: 1c2decbd-c37c-4339-8678-42f1cd037aed

## Text

```text
def replace_expressions(self, replacements)
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
- posted_at: `2026-11-09T22:39:51.9300180+00:00`

## Data

```json
{
  "end_line": 238,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 230,
  "symbol": "WhereNode.replace_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":230,"selector":"L230-L238","symbol":"WhereNode.replace_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.replace_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 238,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 230,
    "symbol": "WhereNode.replace_expressions"
  },
  "id": "1c2decbd-c37c-4339-8678-42f1cd037aed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9300180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 230,
        "selector": "L230-L238",
        "symbol": "WhereNode.replace_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "97a08b92-95a5-4858-a1ea-e62dd7220ce8",
  "subject_name": "django/db/models/sql/where::WhereNode.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```

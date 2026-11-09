# Fact 2e9ba87a

Store id: f3805d30-2319-4e1b-9516-1172e46fe51a

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
- posted_at: `2026-11-09T23:44:59.7441170+00:00`

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
  "id": "f3805d30-2319-4e1b-9516-1172e46fe51a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7441170+00:00"
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
  "subject_id": "50ac2c08-fbe2-4157-99fa-195d0ec7e985",
  "subject_name": "django/db/models/sql/where::WhereNode.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```

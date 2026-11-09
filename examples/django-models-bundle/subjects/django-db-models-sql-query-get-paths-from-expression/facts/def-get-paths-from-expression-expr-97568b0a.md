# Fact 97568b0a

Store id: 56fc68a4-bf49-4f41-9f87-a64ffab52858

## Text

```text
def get_paths_from_expression(expr)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.1566770+00:00`

## Data

```json
{
  "end_line": 89,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 81,
  "symbol": "get_paths_from_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":81,"selector":"L81-L89","symbol":"get_paths_from_expression"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::get_paths_from_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 89,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 81,
    "symbol": "get_paths_from_expression"
  },
  "id": "56fc68a4-bf49-4f41-9f87-a64ffab52858",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1566770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 81,
        "selector": "L81-L89",
        "symbol": "get_paths_from_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e04e5037-81fb-41fa-bb1c-c39b6177c6ce",
  "subject_name": "django/db/models/sql/query::get_paths_from_expression",
  "tags": [
    "entity:function"
  ],
  "text": "def get_paths_from_expression(expr)"
}
```

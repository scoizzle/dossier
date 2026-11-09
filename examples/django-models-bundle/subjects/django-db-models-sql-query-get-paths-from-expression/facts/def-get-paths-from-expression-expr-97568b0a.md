# Fact 97568b0a

Store id: ce38d945-f2e4-4e3c-bf3c-fef7db8afb3f

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
- posted_at: `2026-11-09T23:44:58.4939990+00:00`

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
  "id": "ce38d945-f2e4-4e3c-bf3c-fef7db8afb3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.4939990+00:00"
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
  "subject_id": "026504a8-255d-4712-a176-3e0cc9cddbc8",
  "subject_name": "django/db/models/sql/query::get_paths_from_expression",
  "tags": [
    "entity:function"
  ],
  "text": "def get_paths_from_expression(expr)"
}
```

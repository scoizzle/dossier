# Fact 4727a12d

Store id: dab71ff7-5c03-4e00-b9f5-7a3fecbd6f9a

## Text

```text
def _resolve_combined_type(connector, lhs_type, rhs_type)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`, `decorator:functools.lru_cache`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5424770+00:00`

## Data

```json
{
  "end_line": 725,
  "entity_kind": "function",
  "parent": "expressions",
  "start_line": 718,
  "symbol": "_resolve_combined_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":718,"selector":"L718-L725","symbol":"_resolve_combined_type"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::_resolve_combined_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 725,
    "entity_kind": "function",
    "parent": "expressions",
    "start_line": 718,
    "symbol": "_resolve_combined_type"
  },
  "id": "dab71ff7-5c03-4e00-b9f5-7a3fecbd6f9a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5424770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 718,
        "selector": "L718-L725",
        "symbol": "_resolve_combined_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "06e0c899-618d-43d5-959f-d3555deec2bc",
  "subject_name": "django/db/models/expressions::_resolve_combined_type",
  "tags": [
    "entity:function",
    "decorator:functools.lru_cache"
  ],
  "text": "def _resolve_combined_type(connector, lhs_type, rhs_type)"
}
```

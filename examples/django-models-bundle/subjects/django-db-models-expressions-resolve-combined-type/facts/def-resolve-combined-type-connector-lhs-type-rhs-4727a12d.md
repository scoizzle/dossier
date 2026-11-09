# Fact 4727a12d

Store id: 41df11c4-edad-42a3-97f2-fcd4d50a1583

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
- posted_at: `2026-11-09T23:31:55.8077980+00:00`

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
  "id": "41df11c4-edad-42a3-97f2-fcd4d50a1583",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8077980+00:00"
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
  "subject_id": "bd79456f-d7bb-49dd-8783-e3c6bd27ecd5",
  "subject_name": "django/db/models/expressions::_resolve_combined_type",
  "tags": [
    "entity:function",
    "decorator:functools.lru_cache"
  ],
  "text": "def _resolve_combined_type(connector, lhs_type, rhs_type)"
}
```

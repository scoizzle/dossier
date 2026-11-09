# Fact 42659cc5

Store id: 21da40d8-aa6c-4e39-8e0e-5081f3e765a0

## Text

```text
def _gen_cols(cls, exprs, include_external=False, resolve_refs=True)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:58.9023440+00:00`

## Data

```json
{
  "end_line": 2055,
  "entity_kind": "class_method",
  "parent": "Query",
  "start_line": 2039,
  "symbol": "Query._gen_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2039,"selector":"L2039-L2055","symbol":"Query._gen_cols"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._gen_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2055,
    "entity_kind": "class_method",
    "parent": "Query",
    "start_line": 2039,
    "symbol": "Query._gen_cols"
  },
  "id": "21da40d8-aa6c-4e39-8e0e-5081f3e765a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9023440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2039,
        "selector": "L2039-L2055",
        "symbol": "Query._gen_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "08740bc2-3457-4eab-9426-73e18834c2df",
  "subject_name": "django/db/models/sql/query::Query._gen_cols",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _gen_cols(cls, exprs, include_external=False, resolve_refs=True)"
}
```

# Fact b8fd3059

Store id: 9892fe0c-90c0-4eff-be5e-e4be09e8c821

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:44:49.5123460+00:00`

## Data

```json
{
  "end_line": 1095,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1094,
  "symbol": "Func.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1094,"selector":"L1094-L1095","symbol":"Func.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1095,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1094,
    "symbol": "Func.set_source_expressions"
  },
  "id": "9892fe0c-90c0-4eff-be5e-e4be09e8c821",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5123460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1094,
        "selector": "L1094-L1095",
        "symbol": "Func.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2544e5ab-1fe9-4baf-9c5e-5a07db3c23d1",
  "subject_name": "django/db/models/expressions::Func.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

# Fact 98561628

Store id: 0110f53d-a6ed-49ba-b554-ec00b07d8265

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
- posted_at: `2026-11-09T23:44:49.6558990+00:00`

## Data

```json
{
  "end_line": 1939,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1938,
  "symbol": "OrderBy.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1938,"selector":"L1938-L1939","symbol":"OrderBy.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1939,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1938,
    "symbol": "OrderBy.set_source_expressions"
  },
  "id": "0110f53d-a6ed-49ba-b554-ec00b07d8265",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6558990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1938,
        "selector": "L1938-L1939",
        "symbol": "OrderBy.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d5895fa4-39b3-49e8-b864-a940f773f9e6",
  "subject_name": "django/db/models/expressions::OrderBy.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

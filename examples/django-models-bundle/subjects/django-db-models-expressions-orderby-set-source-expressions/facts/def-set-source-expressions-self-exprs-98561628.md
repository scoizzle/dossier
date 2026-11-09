# Fact 98561628

Store id: f16c9dab-7315-44a9-8171-467a00d85e11

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
- posted_at: `2026-11-09T22:39:41.7439310+00:00`

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
  "id": "f16c9dab-7315-44a9-8171-467a00d85e11",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7439310+00:00"
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
  "subject_id": "cc19dc48-e04f-4f9f-a958-bfe4d6cf3b3d",
  "subject_name": "django/db/models/expressions::OrderBy.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

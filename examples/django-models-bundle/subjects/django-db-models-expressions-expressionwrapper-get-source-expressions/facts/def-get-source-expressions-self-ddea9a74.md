# Fact ddea9a74

Store id: 030b09dd-89fb-40c1-ba5b-14b2677715b7

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:31:55.9352740+00:00`

## Data

```json
{
  "end_line": 1562,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1561,
  "symbol": "ExpressionWrapper.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1561,"selector":"L1561-L1562","symbol":"ExpressionWrapper.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1562,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1561,
    "symbol": "ExpressionWrapper.get_source_expressions"
  },
  "id": "030b09dd-89fb-40c1-ba5b-14b2677715b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9352740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1561,
        "selector": "L1561-L1562",
        "symbol": "ExpressionWrapper.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "82f65132-1f2c-43d4-b6d9-1f7834cf01cb",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

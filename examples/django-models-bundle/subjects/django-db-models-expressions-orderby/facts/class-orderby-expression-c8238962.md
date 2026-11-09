# Fact c8238962

Store id: 3a3faf82-8307-4f19-8a97-ddef9acd2790

## Text

```text
class OrderBy(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:deconstructible`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.6514070+00:00`

## Data

```json
{
  "end_line": 2017,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1914,
  "symbol": "OrderBy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1914,"selector":"L1914-L2017","symbol":"OrderBy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2017,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1914,
    "symbol": "OrderBy"
  },
  "id": "3a3faf82-8307-4f19-8a97-ddef9acd2790",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6514070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1914,
        "selector": "L1914-L2017",
        "symbol": "OrderBy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3d75d827-d0cc-46b2-8f27-bef9b7deadbe",
  "subject_name": "django/db/models/expressions::OrderBy",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class OrderBy(Expression)"
}
```

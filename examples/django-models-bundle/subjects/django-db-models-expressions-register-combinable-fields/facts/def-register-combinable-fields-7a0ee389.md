# Fact 7a0ee389

Store id: da0632af-f362-41cf-b6c2-e5d569ede8b8

## Text

```text
def _register_combinable_fields()
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
- posted_at: `2026-11-09T22:39:41.5416060+00:00`

## Data

```json
{
  "end_line": 712,
  "entity_kind": "function",
  "parent": "expressions",
  "start_line": 708,
  "symbol": "_register_combinable_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":708,"selector":"L708-L712","symbol":"_register_combinable_fields"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::_register_combinable_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 712,
    "entity_kind": "function",
    "parent": "expressions",
    "start_line": 708,
    "symbol": "_register_combinable_fields"
  },
  "id": "da0632af-f362-41cf-b6c2-e5d569ede8b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5416060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 708,
        "selector": "L708-L712",
        "symbol": "_register_combinable_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cdb69da6-efac-45ff-bc70-f47e8edea265",
  "subject_name": "django/db/models/expressions::_register_combinable_fields",
  "tags": [
    "entity:function"
  ],
  "text": "def _register_combinable_fields()"
}
```

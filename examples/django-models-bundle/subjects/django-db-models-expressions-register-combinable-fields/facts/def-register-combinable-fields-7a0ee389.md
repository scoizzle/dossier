# Fact 7a0ee389

Store id: 58efbccf-f118-4595-8435-985c884be50c

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
- posted_at: `2026-11-09T23:44:49.4296790+00:00`

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
  "id": "58efbccf-f118-4595-8435-985c884be50c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4296790+00:00"
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
  "subject_id": "86b016ca-6f4b-4cc6-8eb8-fd123bc52cfc",
  "subject_name": "django/db/models/expressions::_register_combinable_fields",
  "tags": [
    "entity:function"
  ],
  "text": "def _register_combinable_fields()"
}
```

# Fact 608ba66c

Store id: ff2503ae-492f-4afa-8bd4-afdfb5f41912

## Text

```text
def empty_result_set_value(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5997940+00:00`

## Data

```json
{
  "end_line": 1241,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1239,
  "symbol": "Value.empty_result_set_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1239,"selector":"L1239-L1241","symbol":"Value.empty_result_set_value"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.empty_result_set_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1241,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1239,
    "symbol": "Value.empty_result_set_value"
  },
  "id": "ff2503ae-492f-4afa-8bd4-afdfb5f41912",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5997940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1239,
        "selector": "L1239-L1241",
        "symbol": "Value.empty_result_set_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6d135f0f-777e-4fa1-b79b-2853bf94f781",
  "subject_name": "django/db/models/expressions::Value.empty_result_set_value",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def empty_result_set_value(self)"
}
```

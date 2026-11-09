# Fact 608ba66c

Store id: 43efa03b-240d-4960-9353-90ae00b344ed

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
- posted_at: `2026-11-09T23:44:49.5310680+00:00`

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
  "id": "43efa03b-240d-4960-9353-90ae00b344ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5310680+00:00"
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
  "subject_id": "e6618026-4023-48f1-a9b4-51c42508f333",
  "subject_name": "django/db/models/expressions::Value.empty_result_set_value",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def empty_result_set_value(self)"
}
```

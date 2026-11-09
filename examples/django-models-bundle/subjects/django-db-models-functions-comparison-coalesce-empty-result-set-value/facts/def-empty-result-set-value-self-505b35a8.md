# Fact 505b35a8

Store id: 2a932fc4-dba0-4468-94d1-07d43e74e881

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
- posted_at: `2026-11-09T23:44:53.1492460+00:00`

## Data

```json
{
  "end_line": 86,
  "entity_kind": "method",
  "parent": "Coalesce",
  "start_line": 80,
  "symbol": "Coalesce.empty_result_set_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"selector":"L80-L86","symbol":"Coalesce.empty_result_set_value"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Coalesce.empty_result_set_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 86,
    "entity_kind": "method",
    "parent": "Coalesce",
    "start_line": 80,
    "symbol": "Coalesce.empty_result_set_value"
  },
  "id": "2a932fc4-dba0-4468-94d1-07d43e74e881",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1492460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 80,
        "selector": "L80-L86",
        "symbol": "Coalesce.empty_result_set_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "a41609ed-757d-4a3c-b1a3-85e0218e6158",
  "subject_name": "django/db/models/functions/comparison::Coalesce.empty_result_set_value",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def empty_result_set_value(self)"
}
```

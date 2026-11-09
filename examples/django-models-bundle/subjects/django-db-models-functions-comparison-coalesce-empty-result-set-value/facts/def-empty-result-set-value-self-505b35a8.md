# Fact 505b35a8

Store id: 09c08525-bbaf-4fe6-8134-cf152a61d5e7

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
- posted_at: `2026-11-09T22:39:45.9295310+00:00`

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
  "id": "09c08525-bbaf-4fe6-8134-cf152a61d5e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9295310+00:00"
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
  "subject_id": "fab0efee-7946-475e-a0a4-b922b107e805",
  "subject_name": "django/db/models/functions/comparison::Coalesce.empty_result_set_value",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def empty_result_set_value(self)"
}
```

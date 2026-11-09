# Fact fad3e6a3

Store id: 086a644a-7012-447f-8378-37c277edffa3

## Text

```text
def set_managed(model, related, through)
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
- posted_at: `2026-11-09T23:31:58.8226030+00:00`

## Data

```json
{
  "end_line": 1405,
  "entity_kind": "function",
  "parent": "create_many_to_many_intermediary_model",
  "start_line": 1404,
  "symbol": "create_many_to_many_intermediary_model.set_managed"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1404,"selector":"L1404-L1405","symbol":"create_many_to_many_intermediary_model.set_managed"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::create_many_to_many_intermediary_model.set_managed](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1405,
    "entity_kind": "function",
    "parent": "create_many_to_many_intermediary_model",
    "start_line": 1404,
    "symbol": "create_many_to_many_intermediary_model.set_managed"
  },
  "id": "086a644a-7012-447f-8378-37c277edffa3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8226030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1404,
        "selector": "L1404-L1405",
        "symbol": "create_many_to_many_intermediary_model.set_managed"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e93b65cc-a611-485c-90d5-67dbd4d3e589",
  "subject_name": "django/db/models/fields/related::create_many_to_many_intermediary_model.set_managed",
  "tags": [
    "entity:function"
  ],
  "text": "def set_managed(model, related, through)"
}
```

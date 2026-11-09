# Fact 366a0f1b

Store id: e59f5c23-0e7b-46c7-8244-5daa2dc2a218

## Text

```text
def get_current_to_attr(self, level)
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
- posted_at: `2026-11-09T23:44:56.2935380+00:00`

## Data

```json
{
  "end_line": 2615,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2611,
  "symbol": "Prefetch.get_current_to_attr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2611,"selector":"L2611-L2615","symbol":"Prefetch.get_current_to_attr"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.get_current_to_attr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2615,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2611,
    "symbol": "Prefetch.get_current_to_attr"
  },
  "id": "e59f5c23-0e7b-46c7-8244-5daa2dc2a218",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2935380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2611,
        "selector": "L2611-L2615",
        "symbol": "Prefetch.get_current_to_attr"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d5354af2-5e10-4ce8-a7a4-f53550c731f8",
  "subject_name": "django/db/models/query::Prefetch.get_current_to_attr",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_to_attr(self, level)"
}
```

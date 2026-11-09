# Fact d8f75a84

Store id: ee5302ad-b054-4fc4-af4b-baaf01389d93

## Text

```text
def __init__(self, class_method, instance_method)
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
- posted_at: `2026-11-09T22:39:50.1304870+00:00`

## Data

```json
{
  "end_line": 328,
  "entity_kind": "method",
  "parent": "class_or_instance_method",
  "start_line": 326,
  "symbol": "class_or_instance_method.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":326,"selector":"L326-L328","symbol":"class_or_instance_method.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::class_or_instance_method.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 328,
    "entity_kind": "method",
    "parent": "class_or_instance_method",
    "start_line": 326,
    "symbol": "class_or_instance_method.__init__"
  },
  "id": "ee5302ad-b054-4fc4-af4b-baaf01389d93",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1304870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 326,
        "selector": "L326-L328",
        "symbol": "class_or_instance_method.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "52a80b10-cf7e-404e-a73b-f5d034c9048a",
  "subject_name": "django/db/models/query_utils::class_or_instance_method.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, class_method, instance_method)"
}
```

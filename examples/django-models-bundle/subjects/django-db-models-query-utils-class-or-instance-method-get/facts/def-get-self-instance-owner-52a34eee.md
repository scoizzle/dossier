# Fact 52a34eee

Store id: 6fe857e4-4cef-4572-abf5-afa788f15fa5

## Text

```text
def __get__(self, instance, owner)
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
- posted_at: `2026-11-09T23:44:56.6499890+00:00`

## Data

```json
{
  "end_line": 333,
  "entity_kind": "method",
  "parent": "class_or_instance_method",
  "start_line": 330,
  "symbol": "class_or_instance_method.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":330,"selector":"L330-L333","symbol":"class_or_instance_method.__get__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::class_or_instance_method.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 333,
    "entity_kind": "method",
    "parent": "class_or_instance_method",
    "start_line": 330,
    "symbol": "class_or_instance_method.__get__"
  },
  "id": "6fe857e4-4cef-4572-abf5-afa788f15fa5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6499890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 330,
        "selector": "L330-L333",
        "symbol": "class_or_instance_method.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "1dff3293-7c72-4684-9e65-4dba90d11125",
  "subject_name": "django/db/models/query_utils::class_or_instance_method.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, owner)"
}
```

# Fact 78e7a890

Store id: cccc8085-4c8b-482b-b6ec-143360f550e1

## Text

```text
def prefetch_one_level(instances, prefetcher, lookup, level)
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
- posted_at: `2026-11-09T23:32:04.8517320+00:00`

## Data

```json
{
  "end_line": 2981,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 2874,
  "symbol": "prefetch_one_level"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2874,"selector":"L2874-L2981","symbol":"prefetch_one_level"}`

## Items

```json
[
  {
    "text": "Helper function for prefetch_related_objects().",
    "locator": {
      "line": 2875
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::prefetch_one_level](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2981,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 2874,
    "symbol": "prefetch_one_level"
  },
  "id": "cccc8085-4c8b-482b-b6ec-143360f550e1",
  "items": [
    {
      "locator": {
        "line": 2875
      },
      "text": "Helper function for prefetch_related_objects()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8517320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2874,
        "selector": "L2874-L2981",
        "symbol": "prefetch_one_level"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "137dd2a0-b608-4611-8eec-2ff4e49adfd5",
  "subject_name": "django/db/models/query::prefetch_one_level",
  "tags": [
    "entity:function"
  ],
  "text": "def prefetch_one_level(instances, prefetcher, lookup, level)"
}
```

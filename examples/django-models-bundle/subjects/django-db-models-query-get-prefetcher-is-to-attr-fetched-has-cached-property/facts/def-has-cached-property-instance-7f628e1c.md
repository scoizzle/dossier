# Fact 7f628e1c

Store id: 5ce81c16-4244-45d9-966e-80c344974007

## Text

```text
def has_cached_property(instance)
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
- posted_at: `2026-11-09T22:39:49.8864110+00:00`

## Data

```json
{
  "end_line": 2827,
  "entity_kind": "function",
  "parent": "get_prefetcher.is_to_attr_fetched",
  "start_line": 2826,
  "symbol": "get_prefetcher.is_to_attr_fetched.has_cached_property"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2826,"selector":"L2826-L2827","symbol":"get_prefetcher.is_to_attr_fetched.has_cached_property"}`

## Referenced by

None.

## Subject

[django/db/models/query::get_prefetcher.is_to_attr_fetched.has_cached_property](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2827,
    "entity_kind": "function",
    "parent": "get_prefetcher.is_to_attr_fetched",
    "start_line": 2826,
    "symbol": "get_prefetcher.is_to_attr_fetched.has_cached_property"
  },
  "id": "5ce81c16-4244-45d9-966e-80c344974007",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8864110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2826,
        "selector": "L2826-L2827",
        "symbol": "get_prefetcher.is_to_attr_fetched.has_cached_property"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "887bd389-f87b-4fdb-a2de-682e12e775f2",
  "subject_name": "django/db/models/query::get_prefetcher.is_to_attr_fetched.has_cached_property",
  "tags": [
    "entity:function"
  ],
  "text": "def has_cached_property(instance)"
}
```

# Fact 7f628e1c

Store id: 147f6f02-0511-495c-94cc-d3d051a7e9df

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
- posted_at: `2026-11-09T23:44:56.3212080+00:00`

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
  "id": "147f6f02-0511-495c-94cc-d3d051a7e9df",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3212080+00:00"
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
  "subject_id": "58b87017-b94f-484c-8623-a133391773f4",
  "subject_name": "django/db/models/query::get_prefetcher.is_to_attr_fetched.has_cached_property",
  "tags": [
    "entity:function"
  ],
  "text": "def has_cached_property(instance)"
}
```

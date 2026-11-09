# Fact 7f628e1c

Store id: 2f9b3d9e-47f9-43ab-bfef-748521b1e868

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
- posted_at: `2026-11-09T23:32:04.8386940+00:00`

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
  "id": "2f9b3d9e-47f9-43ab-bfef-748521b1e868",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8386940+00:00"
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
  "subject_id": "47d178f6-cfe2-401e-beb5-e70d077d097e",
  "subject_name": "django/db/models/query::get_prefetcher.is_to_attr_fetched.has_cached_property",
  "tags": [
    "entity:function"
  ],
  "text": "def has_cached_property(instance)"
}
```

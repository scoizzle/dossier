# Fact d380cbb3

Store id: 6fa939cb-b6f1-44b4-b955-8125421ee836

## Text

```text
def has_to_attr_attribute(instance)
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
- posted_at: `2026-11-09T23:32:04.8428930+00:00`

## Data

```json
{
  "end_line": 2832,
  "entity_kind": "function",
  "parent": "get_prefetcher.is_to_attr_fetched",
  "start_line": 2831,
  "symbol": "get_prefetcher.is_to_attr_fetched.has_to_attr_attribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2831,"selector":"L2831-L2832","symbol":"get_prefetcher.is_to_attr_fetched.has_to_attr_attribute"}`

## Referenced by

None.

## Subject

[django/db/models/query::get_prefetcher.is_to_attr_fetched.has_to_attr_attribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2832,
    "entity_kind": "function",
    "parent": "get_prefetcher.is_to_attr_fetched",
    "start_line": 2831,
    "symbol": "get_prefetcher.is_to_attr_fetched.has_to_attr_attribute"
  },
  "id": "6fa939cb-b6f1-44b4-b955-8125421ee836",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8428930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2831,
        "selector": "L2831-L2832",
        "symbol": "get_prefetcher.is_to_attr_fetched.has_to_attr_attribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8062a76b-e33b-4953-981e-7e1d4cc481ab",
  "subject_name": "django/db/models/query::get_prefetcher.is_to_attr_fetched.has_to_attr_attribute",
  "tags": [
    "entity:function"
  ],
  "text": "def has_to_attr_attribute(instance)"
}
```

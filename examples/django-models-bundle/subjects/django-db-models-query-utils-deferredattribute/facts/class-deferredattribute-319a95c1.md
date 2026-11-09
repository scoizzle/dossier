# Fact 319a95c1

Store id: c11d5739-c31c-446d-b2f6-e2d0eede9510

## Text

```text
class DeferredAttribute
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.6037920+00:00`

## Data

```json
{
  "end_line": 317,
  "entity_kind": "class",
  "parent": "query_utils",
  "start_line": 250,
  "symbol": "DeferredAttribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":250,"selector":"L250-L317","symbol":"DeferredAttribute"}`

## Items

```json
[
  {
    "text": "A wrapper for a deferred-loading field. When the value is read from this object the first time, the query is executed.",
    "locator": {
      "line": 251
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::DeferredAttribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 317,
    "entity_kind": "class",
    "parent": "query_utils",
    "start_line": 250,
    "symbol": "DeferredAttribute"
  },
  "id": "c11d5739-c31c-446d-b2f6-e2d0eede9510",
  "items": [
    {
      "locator": {
        "line": 251
      },
      "text": "A wrapper for a deferred-loading field. When the value is read from this object the first time, the query is executed."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6037920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 250,
        "selector": "L250-L317",
        "symbol": "DeferredAttribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "8338ff95-1140-4fd5-9538-b536d54a7662",
  "subject_name": "django/db/models/query_utils::DeferredAttribute",
  "tags": [
    "entity:class"
  ],
  "text": "class DeferredAttribute"
}
```

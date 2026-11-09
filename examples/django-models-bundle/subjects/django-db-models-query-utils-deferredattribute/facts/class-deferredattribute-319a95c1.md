# Fact 319a95c1

Store id: 8779be85-ce02-4902-8ad9-32a21b7d7c39

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
- posted_at: `2026-11-09T23:32:05.1043300+00:00`

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
  "id": "8779be85-ce02-4902-8ad9-32a21b7d7c39",
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
    "posted_at": "2026-11-09T23:32:05.1043300+00:00"
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
  "subject_id": "b467f470-ebc9-4b8f-8331-643618164d83",
  "subject_name": "django/db/models/query_utils::DeferredAttribute",
  "tags": [
    "entity:class"
  ],
  "text": "class DeferredAttribute"
}
```

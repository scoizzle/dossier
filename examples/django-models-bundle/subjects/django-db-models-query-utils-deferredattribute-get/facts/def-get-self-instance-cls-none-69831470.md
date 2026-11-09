# Fact 69831470

Store id: e34d944d-779e-42b6-a46f-df4aeda27b6b

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T22:39:50.1157610+00:00`

## Data

```json
{
  "end_line": 287,
  "entity_kind": "method",
  "parent": "DeferredAttribute",
  "start_line": 259,
  "symbol": "DeferredAttribute.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":259,"selector":"L259-L287","symbol":"DeferredAttribute.__get__"}`

## Items

```json
[
  {
    "text": "Retrieve and caches the value from the datastore on the first lookup. Return the cached value.",
    "locator": {
      "line": 260
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::DeferredAttribute.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 287,
    "entity_kind": "method",
    "parent": "DeferredAttribute",
    "start_line": 259,
    "symbol": "DeferredAttribute.__get__"
  },
  "id": "e34d944d-779e-42b6-a46f-df4aeda27b6b",
  "items": [
    {
      "locator": {
        "line": 260
      },
      "text": "Retrieve and caches the value from the datastore on the first lookup. Return the cached value."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1157610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 259,
        "selector": "L259-L287",
        "symbol": "DeferredAttribute.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "0438673a-1e3f-4880-877a-1de81dbb05e0",
  "subject_name": "django/db/models/query_utils::DeferredAttribute.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```

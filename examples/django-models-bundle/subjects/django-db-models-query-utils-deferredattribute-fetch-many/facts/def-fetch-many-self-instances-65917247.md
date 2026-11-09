# Fact 65917247

Store id: 6a31428a-03ec-4c7b-b689-c73a9ea80e09

## Text

```text
def fetch_many(self, instances)
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
- posted_at: `2026-11-09T23:44:56.6316570+00:00`

## Data

```json
{
  "end_line": 317,
  "entity_kind": "method",
  "parent": "DeferredAttribute",
  "start_line": 304,
  "symbol": "DeferredAttribute.fetch_many"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":304,"selector":"L304-L317","symbol":"DeferredAttribute.fetch_many"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::DeferredAttribute.fetch_many](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 317,
    "entity_kind": "method",
    "parent": "DeferredAttribute",
    "start_line": 304,
    "symbol": "DeferredAttribute.fetch_many"
  },
  "id": "6a31428a-03ec-4c7b-b689-c73a9ea80e09",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6316570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 304,
        "selector": "L304-L317",
        "symbol": "DeferredAttribute.fetch_many"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "e79c5cb8-f352-498b-b6b8-777c7d42d9c0",
  "subject_name": "django/db/models/query_utils::DeferredAttribute.fetch_many",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_many(self, instances)"
}
```

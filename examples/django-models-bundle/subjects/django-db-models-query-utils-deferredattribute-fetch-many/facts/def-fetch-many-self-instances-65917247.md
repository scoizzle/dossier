# Fact 65917247

Store id: d3937544-8f0f-4bf2-a852-2f79568dc1cd

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
- posted_at: `2026-11-09T22:39:50.1244060+00:00`

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
  "id": "d3937544-8f0f-4bf2-a852-2f79568dc1cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1244060+00:00"
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
  "subject_id": "59035020-9a0e-4bce-b8ae-d259900a4724",
  "subject_name": "django/db/models/query_utils::DeferredAttribute.fetch_many",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_many(self, instances)"
}
```

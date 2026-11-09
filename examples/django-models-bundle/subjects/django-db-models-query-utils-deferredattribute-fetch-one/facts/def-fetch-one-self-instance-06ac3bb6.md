# Fact 06ac3bb6

Store id: 70bd5d81-a40f-410c-816b-0f99d03a23fe

## Text

```text
def fetch_one(self, instance)
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
- posted_at: `2026-11-09T23:44:56.6244360+00:00`

## Data

```json
{
  "end_line": 302,
  "entity_kind": "method",
  "parent": "DeferredAttribute",
  "start_line": 301,
  "symbol": "DeferredAttribute.fetch_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":301,"selector":"L301-L302","symbol":"DeferredAttribute.fetch_one"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::DeferredAttribute.fetch_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 302,
    "entity_kind": "method",
    "parent": "DeferredAttribute",
    "start_line": 301,
    "symbol": "DeferredAttribute.fetch_one"
  },
  "id": "70bd5d81-a40f-410c-816b-0f99d03a23fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6244360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 301,
        "selector": "L301-L302",
        "symbol": "DeferredAttribute.fetch_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "1374c4b4-6e2c-444e-b315-d08545627c45",
  "subject_name": "django/db/models/query_utils::DeferredAttribute.fetch_one",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_one(self, instance)"
}
```

# Fact 06ac3bb6

Store id: 139cdebb-e13b-4558-aa3a-4f68fada4ec9

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
- posted_at: `2026-11-09T22:39:50.1212710+00:00`

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
  "id": "139cdebb-e13b-4558-aa3a-4f68fada4ec9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1212710+00:00"
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
  "subject_id": "bffff1b1-0651-406c-93fa-9409aa9a44aa",
  "subject_name": "django/db/models/query_utils::DeferredAttribute.fetch_one",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_one(self, instance)"
}
```

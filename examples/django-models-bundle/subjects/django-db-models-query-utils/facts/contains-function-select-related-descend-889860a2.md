# Fact 889860a2

Store id: 2fb6556c-0d38-4cfa-9f8b-68d7def52091

## Text

```text
contains function select_related_descend
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
- posted_at: `2026-11-09T23:32:05.2268070+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query_utils::select_related_descend](../../django-db-models-query-utils-select-related-descend/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":440,"symbol":"select_related_descend"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2fb6556c-0d38-4cfa-9f8b-68d7def52091",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.2268070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 440,
        "symbol": "select_related_descend"
      },
      "rel": "contains",
      "target": "3b80e70a-cbe0-4f35-966d-fcf02e30a787"
    }
  ],
  "status": "live",
  "subject_id": "c693c97c-c89e-4768-9017-bc6868b175fc",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function select_related_descend"
}
```

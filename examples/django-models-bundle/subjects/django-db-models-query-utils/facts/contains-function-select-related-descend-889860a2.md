# Fact 889860a2

Store id: d9e6e118-9ce5-4c06-82cb-09be17cefb87

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
- posted_at: `2026-11-09T23:44:56.7745430+00:00`

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
  "id": "d9e6e118-9ce5-4c06-82cb-09be17cefb87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7745430+00:00"
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
      "target": "301a5df9-77e7-463e-9e4a-5ff8c5fceaf9"
    }
  ],
  "status": "live",
  "subject_id": "c4182f55-5c15-42df-8e00-aa953309eedf",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function select_related_descend"
}
```

# Fact 889860a2

Store id: 7dc4e42a-7370-4743-9bc3-e8afb5daab24

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
- posted_at: `2026-11-09T22:39:50.2075540+00:00`

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
  "id": "7dc4e42a-7370-4743-9bc3-e8afb5daab24",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.2075540+00:00"
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
      "target": "7e64db42-7713-4bf0-bd98-88d662c4f947"
    }
  ],
  "status": "live",
  "subject_id": "37abb0c2-46cb-4f07-a1c9-39d94326e8fb",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function select_related_descend"
}
```

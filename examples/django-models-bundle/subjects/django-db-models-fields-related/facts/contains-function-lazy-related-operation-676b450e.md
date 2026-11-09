# Fact 676b450e

Store id: e481986d-9c7e-48c2-bbcf-1548d321d19e

## Text

```text
contains function lazy_related_operation
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
- posted_at: `2026-11-09T23:44:51.6886880+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/related::lazy_related_operation](../../django-db-models-fields-related-lazy-related-operation/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":77,"symbol":"lazy_related_operation"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "e481986d-9c7e-48c2-bbcf-1548d321d19e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6886880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 77,
        "symbol": "lazy_related_operation"
      },
      "rel": "contains",
      "target": "c578eaae-b9fd-4767-ba9d-ed185fa45528"
    }
  ],
  "status": "live",
  "subject_id": "b482f690-f78b-4457-98ca-4cee1c63890e",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:function"
  ],
  "text": "contains function lazy_related_operation"
}
```

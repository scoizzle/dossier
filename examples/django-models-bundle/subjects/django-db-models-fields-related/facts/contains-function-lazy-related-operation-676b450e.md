# Fact 676b450e

Store id: 75c6b90e-1117-48b9-9db5-2be0df1f5341

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
- posted_at: `2026-11-09T22:39:44.5223050+00:00`

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
  "id": "75c6b90e-1117-48b9-9db5-2be0df1f5341",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.5223050+00:00"
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
      "target": "ec71e233-d5a2-4763-966d-046f0450f288"
    }
  ],
  "status": "live",
  "subject_id": "4e7b69d4-8947-48ba-b9c1-385f0d6a435f",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:function"
  ],
  "text": "contains function lazy_related_operation"
}
```

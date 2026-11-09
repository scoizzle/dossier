# Fact 676b450e

Store id: a96bb515-f6af-480c-aee9-a30934ccdb85

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
- posted_at: `2026-11-09T23:31:58.9119250+00:00`

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
  "id": "a96bb515-f6af-480c-aee9-a30934ccdb85",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.9119250+00:00"
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
      "target": "52d2c36d-ee25-44b7-861e-005fae0b71e8"
    }
  ],
  "status": "live",
  "subject_id": "2dd9aa9c-962a-42d5-9466-04fc4602083a",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:function"
  ],
  "text": "contains function lazy_related_operation"
}
```

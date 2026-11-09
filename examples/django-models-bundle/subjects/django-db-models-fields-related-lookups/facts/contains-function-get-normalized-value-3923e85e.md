# Fact 3923e85e

Store id: b75f5dc3-e21d-4933-bc5d-e3c447a75b55

## Text

```text
contains function get_normalized_value
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
- posted_at: `2026-11-09T22:39:45.1401250+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/related_lookups::get_normalized_value](../../django-db-models-fields-related-lookups-get-normalized-value/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":15,"symbol":"get_normalized_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b75f5dc3-e21d-4933-bc5d-e3c447a75b55",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1401250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 15,
        "symbol": "get_normalized_value"
      },
      "rel": "contains",
      "target": "6b5c5003-fb84-4fd1-860f-dd2f5f16b5a4"
    }
  ],
  "status": "live",
  "subject_id": "70a7dfd2-e82a-4d95-871a-306ceb34fbd0",
  "subject_name": "django/db/models/fields/related_lookups",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_normalized_value"
}
```

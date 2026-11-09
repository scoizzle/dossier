# Fact 3923e85e

Store id: d3903444-81e8-40fe-ad2b-67f3dc6dcf4e

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
- posted_at: `2026-11-09T23:32:00.0364670+00:00`

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
  "id": "d3903444-81e8-40fe-ad2b-67f3dc6dcf4e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.0364670+00:00"
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
      "target": "9ed5cc3b-3c3e-4c7c-ba18-0de299538b1d"
    }
  ],
  "status": "live",
  "subject_id": "d5f2171b-837e-44b2-b714-ab9ab8435437",
  "subject_name": "django/db/models/fields/related_lookups",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_normalized_value"
}
```

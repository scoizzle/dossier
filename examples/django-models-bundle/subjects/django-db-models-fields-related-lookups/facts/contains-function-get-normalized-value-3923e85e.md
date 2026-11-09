# Fact 3923e85e

Store id: fee8e0d0-7561-455f-86bf-9a5bc7278140

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
- posted_at: `2026-11-09T23:44:52.2932700+00:00`

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
  "id": "fee8e0d0-7561-455f-86bf-9a5bc7278140",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2932700+00:00"
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
      "target": "c98947f9-3330-414e-800b-8691e959859d"
    }
  ],
  "status": "live",
  "subject_id": "0f597f49-94d5-4386-a469-b67705cdc4d9",
  "subject_name": "django/db/models/fields/related_lookups",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_normalized_value"
}
```

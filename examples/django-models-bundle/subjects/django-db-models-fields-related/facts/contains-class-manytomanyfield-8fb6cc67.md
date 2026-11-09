# Fact 8fb6cc67

Store id: 005c5a66-55d9-411b-b088-b58c51d7cbd7

## Text

```text
contains class ManyToManyField
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.6886880+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/related::ManyToManyField](../../django-db-models-fields-related-manytomanyfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1458,"symbol":"ManyToManyField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "005c5a66-55d9-411b-b088-b58c51d7cbd7",
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
        "line": 1458,
        "symbol": "ManyToManyField"
      },
      "rel": "contains",
      "target": "2f08076c-1fc6-4854-8353-1a682bcfcff0"
    }
  ],
  "status": "live",
  "subject_id": "b482f690-f78b-4457-98ca-4cee1c63890e",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ManyToManyField"
}
```

# Fact 8fb6cc67

Store id: caaba178-78d5-4401-bd3d-9e4c874ff6d6

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
- posted_at: `2026-11-09T22:39:44.5223050+00:00`

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
  "id": "caaba178-78d5-4401-bd3d-9e4c874ff6d6",
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
        "line": 1458,
        "symbol": "ManyToManyField"
      },
      "rel": "contains",
      "target": "7ee0be24-8273-4a13-840b-28c9ea537604"
    }
  ],
  "status": "live",
  "subject_id": "4e7b69d4-8947-48ba-b9c1-385f0d6a435f",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ManyToManyField"
}
```

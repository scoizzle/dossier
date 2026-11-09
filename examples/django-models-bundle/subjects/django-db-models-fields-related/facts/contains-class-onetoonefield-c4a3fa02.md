# Fact c4a3fa02

Store id: 2c114a07-8659-4645-9e69-8adadacb42f6

## Text

```text
contains class OneToOneField
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
  - target: [django/db/models/fields/related::OneToOneField](../../django-db-models-fields-related-onetoonefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1351,"symbol":"OneToOneField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2c114a07-8659-4645-9e69-8adadacb42f6",
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
        "line": 1351,
        "symbol": "OneToOneField"
      },
      "rel": "contains",
      "target": "b2cad620-6b88-4b64-9d46-adb5d25094c9"
    }
  ],
  "status": "live",
  "subject_id": "4e7b69d4-8947-48ba-b9c1-385f0d6a435f",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class OneToOneField"
}
```

# Fact c4a3fa02

Store id: c5138a86-e096-4651-a6b4-d45565c3bae1

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
- posted_at: `2026-11-09T23:44:51.6886880+00:00`

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
  "id": "c5138a86-e096-4651-a6b4-d45565c3bae1",
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
        "line": 1351,
        "symbol": "OneToOneField"
      },
      "rel": "contains",
      "target": "e45ee9fe-339b-437b-a415-f8d9b53be8ed"
    }
  ],
  "status": "live",
  "subject_id": "b482f690-f78b-4457-98ca-4cee1c63890e",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class OneToOneField"
}
```

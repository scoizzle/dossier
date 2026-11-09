# Fact bd1b6f50

Store id: 60fd1046-1f66-4115-83fb-04da7b0feb50

## Text

```text
contains class GenericIPAddressField
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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::GenericIPAddressField](../../django-db-models-fields-init-genericipaddressfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2296,"symbol":"GenericIPAddressField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "60fd1046-1f66-4115-83fb-04da7b0feb50",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7718540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2296,
        "symbol": "GenericIPAddressField"
      },
      "rel": "contains",
      "target": "75733c98-e09c-4bc5-8eb7-07f0734e7133"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GenericIPAddressField"
}
```

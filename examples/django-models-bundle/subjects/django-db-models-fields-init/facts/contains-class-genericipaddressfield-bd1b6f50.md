# Fact bd1b6f50

Store id: 86b7f0ba-1095-4a5e-bec3-062c0360b392

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "86b7f0ba-1095-4a5e-bec3-062c0360b392",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9379270+00:00"
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
      "target": "c62d5ba8-b30e-4da1-a118-b79a8ef4325e"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GenericIPAddressField"
}
```

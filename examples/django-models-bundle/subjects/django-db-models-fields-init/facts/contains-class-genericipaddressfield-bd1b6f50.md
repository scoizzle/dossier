# Fact bd1b6f50

Store id: 97a6d807-0fb4-48f4-b22d-2c6b16b652fd

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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

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
  "id": "97a6d807-0fb4-48f4-b22d-2c6b16b652fd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3490680+00:00"
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
      "target": "99d636e6-1f65-4961-9846-1cb54d23947a"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GenericIPAddressField"
}
```

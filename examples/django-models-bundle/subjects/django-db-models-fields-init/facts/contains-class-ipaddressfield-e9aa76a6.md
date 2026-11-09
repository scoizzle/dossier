# Fact e9aa76a6

Store id: 97a1aa99-b316-4755-884a-d0ad1f58e5b9

## Text

```text
contains class IPAddressField
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
  - target: [django/db/models/fields/__init__::IPAddressField](../../django-db-models-fields-init-ipaddressfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2265,"symbol":"IPAddressField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "97a1aa99-b316-4755-884a-d0ad1f58e5b9",
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
        "line": 2265,
        "symbol": "IPAddressField"
      },
      "rel": "contains",
      "target": "9daf16cd-ee88-454b-9def-1971b5caf162"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class IPAddressField"
}
```

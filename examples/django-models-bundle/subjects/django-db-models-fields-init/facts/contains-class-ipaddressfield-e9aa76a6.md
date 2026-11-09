# Fact e9aa76a6

Store id: 550a5b60-73f5-4da7-91f5-b13f8cd0d699

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "550a5b60-73f5-4da7-91f5-b13f8cd0d699",
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
        "line": 2265,
        "symbol": "IPAddressField"
      },
      "rel": "contains",
      "target": "c27aad2b-4a67-4738-b41f-214012a0c688"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class IPAddressField"
}
```

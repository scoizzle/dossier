# Fact e9aa76a6

Store id: aea2d9d7-9aaa-47ea-90cc-81fb1927c809

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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

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
  "id": "aea2d9d7-9aaa-47ea-90cc-81fb1927c809",
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
        "line": 2265,
        "symbol": "IPAddressField"
      },
      "rel": "contains",
      "target": "a5437c41-fa3a-49cf-a742-18fab56eff10"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class IPAddressField"
}
```

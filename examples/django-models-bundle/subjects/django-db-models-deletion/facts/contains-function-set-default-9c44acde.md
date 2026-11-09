# Fact 9c44acde

Store id: 6ad4b99c-2ad2-4496-9c78-3836db441ee6

## Text

```text
contains function SET_DEFAULT
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.9179750+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/deletion::SET_DEFAULT](../../django-db-models-deletion-set-default/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"symbol":"SET_DEFAULT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "6ad4b99c-2ad2-4496-9c78-3836db441ee6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9179750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 76,
        "symbol": "SET_DEFAULT"
      },
      "rel": "contains",
      "target": "f318a3d2-c0d4-497e-93e6-411396a293b8"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET_DEFAULT"
}
```

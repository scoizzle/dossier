# Fact 613031e9

Store id: 8652ed99-a552-4ea4-b9da-14c08e23b760

## Text

```text
contains function CASCADE
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
  - target: [django/db/models/deletion::CASCADE](../../django-db-models-deletion-cascade/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":22,"symbol":"CASCADE"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "8652ed99-a552-4ea4-b9da-14c08e23b760",
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
        "line": 22,
        "symbol": "CASCADE"
      },
      "rel": "contains",
      "target": "9c959ac2-fcfd-42be-bc19-9ab734ae6a9e"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function CASCADE"
}
```

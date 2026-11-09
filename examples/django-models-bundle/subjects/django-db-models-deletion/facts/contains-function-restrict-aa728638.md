# Fact aa728638

Store id: 71585f15-dc14-4bac-9582-1a088afb4f3c

## Text

```text
contains function RESTRICT
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
  - target: [django/db/models/deletion::RESTRICT](../../django-db-models-deletion-restrict/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":47,"symbol":"RESTRICT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "71585f15-dc14-4bac-9582-1a088afb4f3c",
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
        "line": 47,
        "symbol": "RESTRICT"
      },
      "rel": "contains",
      "target": "fbdef160-cd65-4b4e-a758-2d56c1701818"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function RESTRICT"
}
```

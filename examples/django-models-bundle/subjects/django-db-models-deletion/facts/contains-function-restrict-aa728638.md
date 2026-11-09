# Fact aa728638

Store id: 8e4073ef-3365-4e53-bf88-dd6fca291f58

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
- posted_at: `2026-11-09T22:39:41.0946700+00:00`

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
  "id": "8e4073ef-3365-4e53-bf88-dd6fca291f58",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0946700+00:00"
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
      "target": "30c533f6-3e40-459a-8560-f64c4d8220e9"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function RESTRICT"
}
```

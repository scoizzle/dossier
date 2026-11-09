# Fact 57084b8b

Store id: c93ebc06-e2c1-4482-9ab3-3bc5973902f7

## Text

```text
contains function DO_NOTHING
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
  - target: [django/db/models/deletion::DO_NOTHING](../../django-db-models-deletion-do-nothing/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"symbol":"DO_NOTHING"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "c93ebc06-e2c1-4482-9ab3-3bc5973902f7",
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
        "line": 80,
        "symbol": "DO_NOTHING"
      },
      "rel": "contains",
      "target": "0069c23d-287a-4a08-b84e-3a05742eb4fb"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function DO_NOTHING"
}
```

# Fact 49860d80

Store id: 89e0d4e1-10c9-4de9-bc3b-2f810ea0a80a

## Text

```text
contains class EndsWith
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
- posted_at: `2026-11-09T23:44:55.1315130+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/lookups::EndsWith](../../django-db-models-lookups-endswith/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":646,"symbol":"EndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "89e0d4e1-10c9-4de9-bc3b-2f810ea0a80a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1315130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 646,
        "symbol": "EndsWith"
      },
      "rel": "contains",
      "target": "c6312aae-cc4f-4488-9e84-6a5f835ed150"
    }
  ],
  "status": "live",
  "subject_id": "08d59620-584d-4fa4-9163-3befcd8a2879",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EndsWith"
}
```

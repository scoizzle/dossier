# Fact 49860d80

Store id: 16ebf029-c4b4-4f01-b7a3-85abbc7d2946

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
- posted_at: `2026-11-09T22:39:48.3048640+00:00`

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
  "id": "16ebf029-c4b4-4f01-b7a3-85abbc7d2946",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.3048640+00:00"
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
      "target": "d0f7bb90-9c3a-42ec-a25b-bfd15ecfe4ea"
    }
  ],
  "status": "live",
  "subject_id": "8a4b2e84-bc75-4dfe-afa5-aa8af215b8c6",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EndsWith"
}
```

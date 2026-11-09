# Fact 9eae4409

Store id: 23f23e0f-c171-4ab9-9493-4129cca8fafd

## Text

```text
contains class GreaterThanOrEqual
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
  - target: [django/db/models/lookups::GreaterThanOrEqual](../../django-db-models-lookups-greaterthanorequal/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":430,"symbol":"GreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "23f23e0f-c171-4ab9-9493-4129cca8fafd",
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
        "line": 430,
        "symbol": "GreaterThanOrEqual"
      },
      "rel": "contains",
      "target": "479ddd6b-a073-450b-be99-e584d4b86893"
    }
  ],
  "status": "live",
  "subject_id": "8a4b2e84-bc75-4dfe-afa5-aa8af215b8c6",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GreaterThanOrEqual"
}
```

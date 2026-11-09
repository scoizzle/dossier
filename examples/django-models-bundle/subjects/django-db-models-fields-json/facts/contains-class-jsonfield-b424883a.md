# Fact b424883a

Store id: 27016197-8ade-46e9-8780-fc2a6b8d858c

## Text

```text
contains class JSONField
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
- posted_at: `2026-11-09T23:31:58.0480240+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/json::JSONField](../../django-db-models-fields-json-jsonfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":24,"symbol":"JSONField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "27016197-8ade-46e9-8780-fc2a6b8d858c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0480240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 24,
        "symbol": "JSONField"
      },
      "rel": "contains",
      "target": "7413bc4d-7a81-4bcf-8beb-3fbd2ee69c75"
    }
  ],
  "status": "live",
  "subject_id": "d7c21811-3589-45c9-bd5d-3d65ba6227de",
  "subject_name": "django/db/models/fields/json",
  "tags": [
    "entity:class"
  ],
  "text": "contains class JSONField"
}
```

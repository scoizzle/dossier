# Fact b424883a

Store id: a3dcc716-c5cf-4554-8f1a-bfc84f43b1b3

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
- posted_at: `2026-11-09T23:44:51.0769520+00:00`

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
  "id": "a3dcc716-c5cf-4554-8f1a-bfc84f43b1b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0769520+00:00"
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
      "target": "6603f76f-770b-499e-aed0-4dfb699a73f6"
    }
  ],
  "status": "live",
  "subject_id": "fa67266b-c3d1-46c4-89d8-c39e71d018cd",
  "subject_name": "django/db/models/fields/json",
  "tags": [
    "entity:class"
  ],
  "text": "contains class JSONField"
}
```

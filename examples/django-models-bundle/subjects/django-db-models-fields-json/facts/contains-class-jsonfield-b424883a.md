# Fact b424883a

Store id: 7b2e56f2-0064-444e-a976-ac8b11f03378

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
- posted_at: `2026-11-09T22:39:43.7741560+00:00`

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
  "id": "7b2e56f2-0064-444e-a976-ac8b11f03378",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7741560+00:00"
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
      "target": "69c26a43-d574-4b1f-91ac-eac1f5801c5f"
    }
  ],
  "status": "live",
  "subject_id": "e8033e5a-9cc0-487a-86e5-7f58586f9b90",
  "subject_name": "django/db/models/fields/json",
  "tags": [
    "entity:class"
  ],
  "text": "contains class JSONField"
}
```

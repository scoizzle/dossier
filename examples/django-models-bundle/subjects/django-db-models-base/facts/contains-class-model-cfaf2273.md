# Fact cfaf2273

Store id: ae1ba127-36f2-4f86-8c96-0b468296c64d

## Text

```text
contains class Model
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
- posted_at: `2026-11-09T22:39:40.3699300+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/base::Model](../../django-db-models-base-model/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":501,"symbol":"Model"}`

## Referenced by

None.

## Subject

[django/db/models/base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "ae1ba127-36f2-4f86-8c96-0b468296c64d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3699300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 501,
        "symbol": "Model"
      },
      "rel": "contains",
      "target": "10f9de65-89a8-43be-a914-51ae4cf587ad"
    }
  ],
  "status": "live",
  "subject_id": "70b750e6-0b0a-43ce-80a5-3403f95c66e3",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Model"
}
```

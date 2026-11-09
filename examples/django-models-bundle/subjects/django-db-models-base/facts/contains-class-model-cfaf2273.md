# Fact cfaf2273

Store id: 78f57c55-cbbd-4a78-bb14-db69d20dce33

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
- posted_at: `2026-11-09T23:44:48.5582640+00:00`

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
  "id": "78f57c55-cbbd-4a78-bb14-db69d20dce33",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5582640+00:00"
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
      "target": "bad1f3c7-f53d-4bb7-ab1a-a9910e2e39ea"
    }
  ],
  "status": "live",
  "subject_id": "adcf7c5a-348e-4481-9bc5-dcdd17eb19d6",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Model"
}
```

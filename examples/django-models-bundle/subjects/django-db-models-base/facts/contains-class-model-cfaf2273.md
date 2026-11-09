# Fact cfaf2273

Store id: 1babc65f-5451-4e14-8d32-faeec55084ec

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
- posted_at: `2026-11-09T23:31:53.7768270+00:00`

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
  "id": "1babc65f-5451-4e14-8d32-faeec55084ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7768270+00:00"
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
      "target": "0cc632ae-9a4f-44b4-8d9e-e793efefc1ed"
    }
  ],
  "status": "live",
  "subject_id": "48784eff-2794-4b93-9cfc-4ff4781fa45d",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Model"
}
```

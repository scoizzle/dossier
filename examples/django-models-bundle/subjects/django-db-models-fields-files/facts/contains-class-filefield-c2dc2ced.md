# Fact c2dc2ced

Store id: 2e0a7f8a-d139-499e-83d2-f240e47a3eeb

## Text

```text
contains class FileField
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
- posted_at: `2026-11-09T22:39:43.2793620+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/files::FileField](../../django-db-models-fields-files-filefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":239,"symbol":"FileField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2e0a7f8a-d139-499e-83d2-f240e47a3eeb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2793620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 239,
        "symbol": "FileField"
      },
      "rel": "contains",
      "target": "2a758cdf-971f-4ebd-a33b-58160dc3fcb1"
    }
  ],
  "status": "live",
  "subject_id": "d37d0887-0dd5-4047-907f-028c6ee64afc",
  "subject_name": "django/db/models/fields/files",
  "tags": [
    "entity:class"
  ],
  "text": "contains class FileField"
}
```

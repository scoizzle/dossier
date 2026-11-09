# Fact 55e3d405

Store id: 49edf70a-e6b5-4669-9cb6-3f70837f3de1

## Text

```text
contains class FilePathField
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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::FilePathField](../../django-db-models-fields-init-filepathfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2023,"symbol":"FilePathField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "49edf70a-e6b5-4669-9cb6-3f70837f3de1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7718540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2023,
        "symbol": "FilePathField"
      },
      "rel": "contains",
      "target": "1309dad2-d570-435a-bf32-4ae2441e521f"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class FilePathField"
}
```

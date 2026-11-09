# Fact 55e3d405

Store id: 23c0eae9-d686-46cc-800e-1b0a242d5114

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "23c0eae9-d686-46cc-800e-1b0a242d5114",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9379270+00:00"
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
      "target": "0e66669d-f7ba-49bc-933a-5951b9f1096f"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class FilePathField"
}
```

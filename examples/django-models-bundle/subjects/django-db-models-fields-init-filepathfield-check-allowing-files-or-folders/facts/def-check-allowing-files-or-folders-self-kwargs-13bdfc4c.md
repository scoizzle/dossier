# Fact 13bdfc4c

Store id: 8de8e336-6b09-43a9-8cbb-972457aa20bc

## Text

```text
def _check_allowing_files_or_folders(self, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.5083870+00:00`

## Data

```json
{
  "end_line": 2058,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2048,
  "symbol": "FilePathField._check_allowing_files_or_folders"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2048,"selector":"L2048-L2058","symbol":"FilePathField._check_allowing_files_or_folders"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField._check_allowing_files_or_folders](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2058,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2048,
    "symbol": "FilePathField._check_allowing_files_or_folders"
  },
  "id": "8de8e336-6b09-43a9-8cbb-972457aa20bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5083870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2048,
        "selector": "L2048-L2058",
        "symbol": "FilePathField._check_allowing_files_or_folders"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e66b64a8-eecd-44e3-b24f-835732959c21",
  "subject_name": "django/db/models/fields/__init__::FilePathField._check_allowing_files_or_folders",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_allowing_files_or_folders(self, **kwargs)"
}
```

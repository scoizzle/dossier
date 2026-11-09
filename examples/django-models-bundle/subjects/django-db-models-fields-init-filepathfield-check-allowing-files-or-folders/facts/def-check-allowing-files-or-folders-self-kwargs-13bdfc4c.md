# Fact 13bdfc4c

Store id: 85701e59-2230-4cb6-a76e-e456ae1ae55f

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
- posted_at: `2026-11-09T23:31:56.6742330+00:00`

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
  "id": "85701e59-2230-4cb6-a76e-e456ae1ae55f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6742330+00:00"
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
  "subject_id": "5f5fae30-13dc-4e89-a5a3-36c82946ffee",
  "subject_name": "django/db/models/fields/__init__::FilePathField._check_allowing_files_or_folders",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_allowing_files_or_folders(self, **kwargs)"
}
```

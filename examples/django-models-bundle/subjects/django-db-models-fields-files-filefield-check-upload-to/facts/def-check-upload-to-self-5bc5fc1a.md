# Fact 5bc5fc1a

Store id: 197e9da0-418b-420a-8d05-10bb56fe355c

## Text

```text
def _check_upload_to(self)
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
- posted_at: `2026-11-09T23:31:57.3957030+00:00`

## Data

```json
{
  "end_line": 305,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 293,
  "symbol": "FileField._check_upload_to"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":293,"selector":"L293-L305","symbol":"FileField._check_upload_to"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField._check_upload_to](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 305,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 293,
    "symbol": "FileField._check_upload_to"
  },
  "id": "197e9da0-418b-420a-8d05-10bb56fe355c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3957030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 293,
        "selector": "L293-L305",
        "symbol": "FileField._check_upload_to"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "5236b992-8679-40ad-8ad0-12c1fd9723b7",
  "subject_name": "django/db/models/fields/files::FileField._check_upload_to",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_upload_to(self)"
}
```

# Fact 5bc5fc1a

Store id: e59cbb55-a5ca-4552-9804-e8e79d4d8875

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
- posted_at: `2026-11-09T23:44:50.6547190+00:00`

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
  "id": "e59cbb55-a5ca-4552-9804-e8e79d4d8875",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6547190+00:00"
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
  "subject_id": "24bb2959-9d95-4507-80f8-79d404b82ef3",
  "subject_name": "django/db/models/fields/files::FileField._check_upload_to",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_upload_to(self)"
}
```

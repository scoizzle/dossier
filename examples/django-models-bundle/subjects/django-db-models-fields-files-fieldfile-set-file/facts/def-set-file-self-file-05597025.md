# Fact 05597025

Store id: b8772471-be74-46c0-b5de-aaf3332a8ed5

## Text

```text
def _set_file(self, file)
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
- posted_at: `2026-11-09T23:31:57.3513750+00:00`

## Data

```json
{
  "end_line": 57,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 56,
  "symbol": "FieldFile._set_file"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":56,"selector":"L56-L57","symbol":"FieldFile._set_file"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile._set_file](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 57,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 56,
    "symbol": "FieldFile._set_file"
  },
  "id": "b8772471-be74-46c0-b5de-aaf3332a8ed5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3513750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 56,
        "selector": "L56-L57",
        "symbol": "FieldFile._set_file"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "ddb4e594-1de8-49b5-b88f-f0f93298db7e",
  "subject_name": "django/db/models/fields/files::FieldFile._set_file",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_file(self, file)"
}
```

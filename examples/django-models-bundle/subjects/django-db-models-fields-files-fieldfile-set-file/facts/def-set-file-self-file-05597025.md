# Fact 05597025

Store id: 787cda45-9973-4d11-9c1c-e6f0c61f9d1d

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
- posted_at: `2026-11-09T23:44:50.6216790+00:00`

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
  "id": "787cda45-9973-4d11-9c1c-e6f0c61f9d1d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6216790+00:00"
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
  "subject_id": "9b73c31a-6724-4851-9d0c-7cc56364fc43",
  "subject_name": "django/db/models/fields/files::FieldFile._set_file",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_file(self, file)"
}
```

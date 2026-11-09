# Fact 471482ea

Store id: dc2e8f9d-f1e8-44ee-9d35-961a08488d17

## Text

```text
def delete(self, save=True)
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
- posted_at: `2026-11-09T22:39:43.2619370+00:00`

## Data

```json
{
  "end_line": 417,
  "entity_kind": "method",
  "parent": "ImageFieldFile",
  "start_line": 413,
  "symbol": "ImageFieldFile.delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":413,"selector":"L413-L417","symbol":"ImageFieldFile.delete"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageFieldFile.delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 417,
    "entity_kind": "method",
    "parent": "ImageFieldFile",
    "start_line": 413,
    "symbol": "ImageFieldFile.delete"
  },
  "id": "dc2e8f9d-f1e8-44ee-9d35-961a08488d17",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2619370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 413,
        "selector": "L413-L417",
        "symbol": "ImageFieldFile.delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "e4354d4d-d449-4571-b085-bfdb8b20e8c7",
  "subject_name": "django/db/models/fields/files::ImageFieldFile.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self, save=True)"
}
```

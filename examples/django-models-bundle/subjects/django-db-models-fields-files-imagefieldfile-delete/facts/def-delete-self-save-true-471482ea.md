# Fact 471482ea

Store id: 2448de92-229b-4247-b85d-41323e0f09e3

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
- posted_at: `2026-11-09T23:44:50.6741350+00:00`

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
  "id": "2448de92-229b-4247-b85d-41323e0f09e3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6741350+00:00"
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
  "subject_id": "c80c63de-e671-44b4-b14a-537f9f40ed92",
  "subject_name": "django/db/models/fields/files::ImageFieldFile.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self, save=True)"
}
```

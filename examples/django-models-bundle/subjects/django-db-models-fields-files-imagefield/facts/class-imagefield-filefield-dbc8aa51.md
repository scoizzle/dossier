# Fact dbc8aa51

Store id: 5889baee-5d69-4124-8a0e-c04b99c82fe1

## Text

```text
class ImageField(FileField)
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
- posted_at: `2026-11-09T23:31:57.4314690+00:00`

## Data

```json
{
  "end_line": 541,
  "entity_kind": "class",
  "parent": "files",
  "start_line": 420,
  "symbol": "ImageField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":420,"selector":"L420-L541","symbol":"ImageField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 541,
    "entity_kind": "class",
    "parent": "files",
    "start_line": 420,
    "symbol": "ImageField"
  },
  "id": "5889baee-5d69-4124-8a0e-c04b99c82fe1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4314690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 420,
        "selector": "L420-L541",
        "symbol": "ImageField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "f61b9ac5-48b4-491d-a661-9d8da6a17d03",
  "subject_name": "django/db/models/fields/files::ImageField",
  "tags": [
    "entity:class"
  ],
  "text": "class ImageField(FileField)"
}
```

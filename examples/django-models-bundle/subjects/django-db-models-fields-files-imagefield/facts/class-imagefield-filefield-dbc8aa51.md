# Fact dbc8aa51

Store id: e7e80288-033d-47d6-a4e3-d68f902a5bc6

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
- posted_at: `2026-11-09T23:44:50.6757700+00:00`

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
  "id": "e7e80288-033d-47d6-a4e3-d68f902a5bc6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6757700+00:00"
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
  "subject_id": "ae1f9363-c9f9-491d-8c13-22fcb734c145",
  "subject_name": "django/db/models/fields/files::ImageField",
  "tags": [
    "entity:class"
  ],
  "text": "class ImageField(FileField)"
}
```

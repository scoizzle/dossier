# Fact dbc8aa51

Store id: c63cefd9-8b4e-4250-a8b4-5a5d395ed617

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
- posted_at: `2026-11-09T22:39:43.2635240+00:00`

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
  "id": "c63cefd9-8b4e-4250-a8b4-5a5d395ed617",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2635240+00:00"
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
  "subject_id": "1eec6c97-1f96-4c40-8c9e-68c3c4986667",
  "subject_name": "django/db/models/fields/files::ImageField",
  "tags": [
    "entity:class"
  ],
  "text": "class ImageField(FileField)"
}
```

# Fact db7f0117

Store id: a8c7fbf2-1c5c-4dc9-8508-bb1c4d8a447b

## Text

```text
def _check_image_library_installed(self)
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
- posted_at: `2026-11-09T23:31:57.4364640+00:00`

## Data

```json
{
  "end_line": 458,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 442,
  "symbol": "ImageField._check_image_library_installed"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":442,"selector":"L442-L458","symbol":"ImageField._check_image_library_installed"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField._check_image_library_installed](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 458,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 442,
    "symbol": "ImageField._check_image_library_installed"
  },
  "id": "a8c7fbf2-1c5c-4dc9-8508-bb1c4d8a447b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4364640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 442,
        "selector": "L442-L458",
        "symbol": "ImageField._check_image_library_installed"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "873aa27e-afe5-4d2a-8179-896297395ed6",
  "subject_name": "django/db/models/fields/files::ImageField._check_image_library_installed",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_image_library_installed(self)"
}
```

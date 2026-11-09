# Fact ba0d62e9

Store id: 505fbdb5-2fb3-4030-a15f-e65449bcd7a7

## Text

```text
def generate_filename(self, instance, filename)
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
- posted_at: `2026-11-09T23:44:50.6640210+00:00`

## Data

```json
{
  "end_line": 361,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 348,
  "symbol": "FileField.generate_filename"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":348,"selector":"L348-L361","symbol":"FileField.generate_filename"}`

## Items

```json
[
  {
    "text": "Apply (if callable) or prepend (if a string) upload_to to the filename, then delegate further processing of the name to the storage backend. Until the storage layer, all file paths are expected to be Unix style (with forward slashes).",
    "locator": {
      "line": 349
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.generate_filename](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 361,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 348,
    "symbol": "FileField.generate_filename"
  },
  "id": "505fbdb5-2fb3-4030-a15f-e65449bcd7a7",
  "items": [
    {
      "locator": {
        "line": 349
      },
      "text": "Apply (if callable) or prepend (if a string) upload_to to the filename, then delegate further processing of the name to the storage backend. Until the storage layer, all file paths are expected to be Unix style (with forward slashes)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6640210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 348,
        "selector": "L348-L361",
        "symbol": "FileField.generate_filename"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "ff285097-97a8-4d8f-8264-743e764a0ab9",
  "subject_name": "django/db/models/fields/files::FileField.generate_filename",
  "tags": [
    "entity:method"
  ],
  "text": "def generate_filename(self, instance, filename)"
}
```

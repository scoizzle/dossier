# Fact e452d984

Store id: d6495abb-6b9d-47fe-bcfa-2947e0f1afaa

## Text

```text
def cached_col(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.6186740+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 35,
  "symbol": "GeneratedField.cached_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L39","symbol":"GeneratedField.cached_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.cached_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 35,
    "symbol": "GeneratedField.cached_col"
  },
  "id": "d6495abb-6b9d-47fe-bcfa-2947e0f1afaa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6186740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L39",
        "symbol": "GeneratedField.cached_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "e12e5e56-86e8-4af1-aec0-ec45c3d1fc85",
  "subject_name": "django/db/models/fields/generated::GeneratedField.cached_col",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cached_col(self)"
}
```

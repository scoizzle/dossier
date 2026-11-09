# Fact 43017413

Store id: f45258f1-bbf9-468f-8e93-fbd15e5cb9d8

## Text

```text
class FilePathField(Field)
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
- posted_at: `2026-11-09T22:39:42.4992210+00:00`

## Data

```json
{
  "end_line": 2096,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2023,
  "symbol": "FilePathField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2023,"selector":"L2023-L2096","symbol":"FilePathField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2096,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2023,
    "symbol": "FilePathField"
  },
  "id": "f45258f1-bbf9-468f-8e93-fbd15e5cb9d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4992210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2023,
        "selector": "L2023-L2096",
        "symbol": "FilePathField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1309dad2-d570-435a-bf32-4ae2441e521f",
  "subject_name": "django/db/models/fields/__init__::FilePathField",
  "tags": [
    "entity:class"
  ],
  "text": "class FilePathField(Field)"
}
```

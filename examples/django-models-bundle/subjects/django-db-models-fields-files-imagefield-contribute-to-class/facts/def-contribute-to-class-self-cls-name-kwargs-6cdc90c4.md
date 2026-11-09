# Fact 6cdc90c4

Store id: 28243535-004d-4281-b8b7-3da44b50365f

## Text

```text
def contribute_to_class(self, cls, name, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.6834910+00:00`

## Data

```json
{
  "end_line": 476,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 468,
  "symbol": "ImageField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":468,"selector":"L468-L476","symbol":"ImageField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 476,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 468,
    "symbol": "ImageField.contribute_to_class"
  },
  "id": "28243535-004d-4281-b8b7-3da44b50365f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6834910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 468,
        "selector": "L468-L476",
        "symbol": "ImageField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "e4f6a78c-d050-4198-8478-ba4c9257f567",
  "subject_name": "django/db/models/fields/files::ImageField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```

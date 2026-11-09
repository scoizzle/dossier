# Fact e73c9c79

Store id: ea07397a-84f4-4631-81f1-605b79670fdd

## Text

```text
def update_dimension_fields(self, instance, force=False, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:43.2743290+00:00`

## Data

```json
{
  "end_line": 533,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 478,
  "symbol": "ImageField.update_dimension_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":478,"selector":"L478-L533","symbol":"ImageField.update_dimension_fields"}`

## Items

```json
[
  {
    "text": "Update field's width and height fields, if defined.",
    "locator": {
      "line": 479
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField.update_dimension_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 533,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 478,
    "symbol": "ImageField.update_dimension_fields"
  },
  "id": "ea07397a-84f4-4631-81f1-605b79670fdd",
  "items": [
    {
      "locator": {
        "line": 479
      },
      "text": "Update field's width and height fields, if defined."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2743290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 478,
        "selector": "L478-L533",
        "symbol": "ImageField.update_dimension_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "47ada322-2938-4727-9c8c-98a1d6b65706",
  "subject_name": "django/db/models/fields/files::ImageField.update_dimension_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def update_dimension_fields(self, instance, force=False, *args, **kwargs)"
}
```

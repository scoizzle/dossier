# Fact 56a83eb3

Store id: 8887bcf4-3fdc-4296-9ac2-b158b039c030

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:50.3179160+00:00`

## Data

```json
{
  "end_line": 2903,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2899,
  "symbol": "AutoFieldMixin.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2899,"selector":"L2899-L2903","symbol":"AutoFieldMixin.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2903,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2899,
    "symbol": "AutoFieldMixin.deconstruct"
  },
  "id": "8887bcf4-3fdc-4296-9ac2-b158b039c030",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3179160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2899,
        "selector": "L2899-L2903",
        "symbol": "AutoFieldMixin.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6c73e169-f8e9-4845-9b55-8a6410fdf4c6",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

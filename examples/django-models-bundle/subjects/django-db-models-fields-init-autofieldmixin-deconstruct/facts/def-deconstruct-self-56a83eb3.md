# Fact 56a83eb3

Store id: 31d89591-c832-4555-8d82-b0a06e441dfb

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
- posted_at: `2026-11-09T23:31:56.8975840+00:00`

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
  "id": "31d89591-c832-4555-8d82-b0a06e441dfb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8975840+00:00"
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
  "subject_id": "871be4c1-0cc4-4925-82f3-0d3a88fc2325",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

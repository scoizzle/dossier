# Fact 616ce964

Store id: be77c380-1e7e-4dca-a2f7-58736ee1416b

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
- posted_at: `2026-11-09T22:39:42.6833480+00:00`

## Data

```json
{
  "end_line": 2731,
  "entity_kind": "method",
  "parent": "URLField",
  "start_line": 2727,
  "symbol": "URLField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2727,"selector":"L2727-L2731","symbol":"URLField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::URLField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2731,
    "entity_kind": "method",
    "parent": "URLField",
    "start_line": 2727,
    "symbol": "URLField.deconstruct"
  },
  "id": "be77c380-1e7e-4dca-a2f7-58736ee1416b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6833480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2727,
        "selector": "L2727-L2731",
        "symbol": "URLField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bd0ee409-e9dd-4560-88bf-27e4be3849f6",
  "subject_name": "django/db/models/fields/__init__::URLField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

# Fact 616ce964

Store id: 301131b1-e7b2-46c1-96f2-4c9244563076

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
- posted_at: `2026-11-09T23:44:50.2713760+00:00`

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
  "id": "301131b1-e7b2-46c1-96f2-4c9244563076",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2713760+00:00"
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
  "subject_id": "36dd9857-a7cc-48de-8e27-5b036c63d9ab",
  "subject_name": "django/db/models/fields/__init__::URLField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

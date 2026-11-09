# Fact 616ce964

Store id: 855296d4-fcf7-4785-a40d-308aed86c903

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
- posted_at: `2026-11-09T23:31:56.8361720+00:00`

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
  "id": "855296d4-fcf7-4785-a40d-308aed86c903",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8361720+00:00"
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
  "subject_id": "dde8afef-f652-4b82-a832-0e5b7622ff2e",
  "subject_name": "django/db/models/fields/__init__::URLField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

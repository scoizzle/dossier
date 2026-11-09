# Fact a117621b

Store id: 766059d6-bc61-459d-8b31-a7c922f7e731

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
- posted_at: `2026-11-09T23:44:50.2477060+00:00`

## Data

```json
{
  "end_line": 2593,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2589,
  "symbol": "TextField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2589,"selector":"L2589-L2593","symbol":"TextField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2593,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2589,
    "symbol": "TextField.deconstruct"
  },
  "id": "766059d6-bc61-459d-8b31-a7c922f7e731",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2477060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2589,
        "selector": "L2589-L2593",
        "symbol": "TextField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4e233717-bdf3-4f58-a7d8-8610fb717c9b",
  "subject_name": "django/db/models/fields/__init__::TextField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

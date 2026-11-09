# Fact 303eadf9

Store id: e515848a-0a69-44a0-9d4c-07a92afb399a

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
- posted_at: `2026-11-09T23:44:50.2817760+00:00`

## Data

```json
{
  "end_line": 2778,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2772,
  "symbol": "BinaryField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2772,"selector":"L2772-L2778","symbol":"BinaryField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2778,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2772,
    "symbol": "BinaryField.deconstruct"
  },
  "id": "e515848a-0a69-44a0-9d4c-07a92afb399a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2817760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2772,
        "selector": "L2772-L2778",
        "symbol": "BinaryField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5b17782e-6675-48f9-8d6c-b2bc769275e4",
  "subject_name": "django/db/models/fields/__init__::BinaryField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

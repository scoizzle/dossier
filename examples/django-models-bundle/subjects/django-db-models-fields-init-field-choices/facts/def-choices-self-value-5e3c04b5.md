# Fact 5e3c04b5

Store id: 93c13f1b-ec68-4f67-922d-01368164d2be

## Text

```text
def choices(self, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:choices.setter`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.9878540+00:00`

## Data

```json
{
  "end_line": 589,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 587,
  "symbol": "Field.choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":587,"selector":"L587-L589","symbol":"Field.choices"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 589,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 587,
    "symbol": "Field.choices"
  },
  "id": "93c13f1b-ec68-4f67-922d-01368164d2be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9878540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 587,
        "selector": "L587-L589",
        "symbol": "Field.choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9be077cb-e493-4f16-9cde-5d3b7b651a12",
  "subject_name": "django/db/models/fields/__init__::Field.choices",
  "tags": [
    "entity:method",
    "decorator:choices.setter"
  ],
  "text": "def choices(self, value)"
}
```

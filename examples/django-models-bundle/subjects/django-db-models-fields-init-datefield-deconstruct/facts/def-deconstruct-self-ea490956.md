# Fact ea490956

Store id: c3d9ab97-3cbe-4b31-9976-09e6d5164852

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
- posted_at: `2026-11-09T23:44:50.0883880+00:00`

## Data

```json
{
  "end_line": 1515,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1506,
  "symbol": "DateField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1506,"selector":"L1506-L1515","symbol":"DateField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1515,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1506,
    "symbol": "DateField.deconstruct"
  },
  "id": "c3d9ab97-3cbe-4b31-9976-09e6d5164852",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0883880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1506,
        "selector": "L1506-L1515",
        "symbol": "DateField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3ecbfdfd-0376-4075-a1d9-3c8b19e550ea",
  "subject_name": "django/db/models/fields/__init__::DateField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```

# Fact 47cd2616

Store id: d4d5e8f9-1cd8-46bb-b57f-8b56cab6acc5

## Text

```text
def contribute_to_class(self, cls, name, private_only=False)
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
- posted_at: `2026-11-09T23:44:50.0290660+00:00`

## Data

```json
{
  "end_line": 1006,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 984,
  "symbol": "Field.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":984,"selector":"L984-L1006","symbol":"Field.contribute_to_class"}`

## Items

```json
[
  {
    "text": "Register the field with the model class it belongs to.",
    "locator": {
      "line": 985
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1006,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 984,
    "symbol": "Field.contribute_to_class"
  },
  "id": "d4d5e8f9-1cd8-46bb-b57f-8b56cab6acc5",
  "items": [
    {
      "locator": {
        "line": 985
      },
      "text": "Register the field with the model class it belongs to."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0290660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 984,
        "selector": "L984-L1006",
        "symbol": "Field.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "33dac131-c18e-4eee-883d-ae334f37418f",
  "subject_name": "django/db/models/fields/__init__::Field.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False)"
}
```

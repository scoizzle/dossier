# Fact ce0ae092

Store id: 5f34351e-73cb-4969-9516-7626d8fcbf75

## Text

```text
def _choices_is_value(cls, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.4274840+00:00`

## Data

```json
{
  "end_line": 348,
  "entity_kind": "class_method",
  "parent": "Field",
  "start_line": 346,
  "symbol": "Field._choices_is_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":346,"selector":"L346-L348","symbol":"Field._choices_is_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._choices_is_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 348,
    "entity_kind": "class_method",
    "parent": "Field",
    "start_line": 346,
    "symbol": "Field._choices_is_value"
  },
  "id": "5f34351e-73cb-4969-9516-7626d8fcbf75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4274840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 346,
        "selector": "L346-L348",
        "symbol": "Field._choices_is_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6d1d76e7-226a-4c5d-b7ce-d20c12639fec",
  "subject_name": "django/db/models/fields/__init__::Field._choices_is_value",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _choices_is_value(cls, value)"
}
```

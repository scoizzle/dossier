# Fact ce0ae092

Store id: 0ca63671-fdc6-4933-82d5-caeede7ce81d

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
- posted_at: `2026-11-09T22:39:42.2721580+00:00`

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
  "id": "0ca63671-fdc6-4933-82d5-caeede7ce81d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2721580+00:00"
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
  "subject_id": "4ce5393f-760e-4259-bd33-eab56d81763a",
  "subject_name": "django/db/models/fields/__init__::Field._choices_is_value",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _choices_is_value(cls, value)"
}
```

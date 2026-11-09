# Fact ce0ae092

Store id: b2fc4cfc-e21b-463b-aca2-2a9b1105129b

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
- posted_at: `2026-11-09T23:44:49.9716430+00:00`

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
  "id": "b2fc4cfc-e21b-463b-aca2-2a9b1105129b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9716430+00:00"
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
  "subject_id": "d80cefa3-28b8-42fd-aeba-837f6c174d2e",
  "subject_name": "django/db/models/fields/__init__::Field._choices_is_value",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _choices_is_value(cls, value)"
}
```

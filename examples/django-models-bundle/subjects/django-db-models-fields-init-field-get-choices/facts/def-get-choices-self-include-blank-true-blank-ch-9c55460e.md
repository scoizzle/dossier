# Fact 9c55460e

Store id: 2fbea748-5573-4854-91d4-c8d2bc59b5df

## Text

```text
def get_choices( self, include_blank=True, blank_choice=None, limit_choices_to=None, ordering=(), )
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
- posted_at: `2026-11-09T23:31:56.5280750+00:00`

## Data

```json
{
  "end_line": 1125,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1096,
  "symbol": "Field.get_choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1096,"selector":"L1096-L1125","symbol":"Field.get_choices"}`

## Items

```json
[
  {
    "text": "Return choices with a default blank choices included, for use as <select> choices for this field.",
    "locator": {
      "line": 1103
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1125,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1096,
    "symbol": "Field.get_choices"
  },
  "id": "2fbea748-5573-4854-91d4-c8d2bc59b5df",
  "items": [
    {
      "locator": {
        "line": 1103
      },
      "text": "Return choices with a default blank choices included, for use as <select> choices for this field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5280750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1096,
        "selector": "L1096-L1125",
        "symbol": "Field.get_choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "18e5dead-abe6-44c7-8595-7a2de5ae13dc",
  "subject_name": "django/db/models/fields/__init__::Field.get_choices",
  "tags": [
    "entity:method"
  ],
  "text": "def get_choices( self, include_blank=True, blank_choice=None, limit_choices_to=None, ordering=(), )"
}
```

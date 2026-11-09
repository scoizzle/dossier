# Fact b3aaf6b4

Store id: db99d4e1-deac-4d80-9bae-229edb689689

## Text

```text
def clean(self, value, model_instance)
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
- posted_at: `2026-11-09T23:44:50.0102510+00:00`

## Data

```json
{
  "end_line": 878,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 869,
  "symbol": "Field.clean"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":869,"selector":"L869-L878","symbol":"Field.clean"}`

## Items

```json
[
  {
    "text": "Convert the value's type and run validation. Validation errors from to_python() and validate() are propagated. Return the correct value if no error is raised.",
    "locator": {
      "line": 870
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.clean](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 878,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 869,
    "symbol": "Field.clean"
  },
  "id": "db99d4e1-deac-4d80-9bae-229edb689689",
  "items": [
    {
      "locator": {
        "line": 870
      },
      "text": "Convert the value's type and run validation. Validation errors from to_python() and validate() are propagated. Return the correct value if no error is raised."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0102510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 869,
        "selector": "L869-L878",
        "symbol": "Field.clean"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7cd84498-ff84-45f8-aeea-96f1b92eedaf",
  "subject_name": "django/db/models/fields/__init__::Field.clean",
  "tags": [
    "entity:method"
  ],
  "text": "def clean(self, value, model_instance)"
}
```

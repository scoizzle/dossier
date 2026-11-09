# Fact b3aaf6b4

Store id: 3d5fad64-6b53-4a6d-921c-bc0e335aa2f6

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
- posted_at: `2026-11-09T23:31:56.4703530+00:00`

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
  "id": "3d5fad64-6b53-4a6d-921c-bc0e335aa2f6",
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
    "posted_at": "2026-11-09T23:31:56.4703530+00:00"
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
  "subject_id": "9a00f5cf-7e3d-4ca9-a9f6-baa5fc0af2e0",
  "subject_name": "django/db/models/fields/__init__::Field.clean",
  "tags": [
    "entity:method"
  ],
  "text": "def clean(self, value, model_instance)"
}
```

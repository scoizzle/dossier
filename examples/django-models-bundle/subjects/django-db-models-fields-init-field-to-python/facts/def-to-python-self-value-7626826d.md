# Fact 7626826d

Store id: b04b5856-ed5f-424f-80f2-7f19c32a2678

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T23:31:56.4638660+00:00`

## Data

```json
{
  "end_line": 804,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 798,
  "symbol": "Field.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":798,"selector":"L798-L804","symbol":"Field.to_python"}`

## Items

```json
[
  {
    "text": "Convert the input value into the expected Python data type, raising django.core.exceptions.ValidationError if the data can't be converted. Return the converted value. Subclasses should override this.",
    "locator": {
      "line": 799
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 804,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 798,
    "symbol": "Field.to_python"
  },
  "id": "b04b5856-ed5f-424f-80f2-7f19c32a2678",
  "items": [
    {
      "locator": {
        "line": 799
      },
      "text": "Convert the input value into the expected Python data type, raising django.core.exceptions.ValidationError if the data can't be converted. Return the converted value. Subclasses should override this."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4638660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 798,
        "selector": "L798-L804",
        "symbol": "Field.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "16aa8ea4-e005-4823-ba0e-2fb827b5bed9",
  "subject_name": "django/db/models/fields/__init__::Field.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```

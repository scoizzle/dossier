# Fact 7626826d

Store id: e96d232a-23ac-4df2-94db-0531562e2894

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
- posted_at: `2026-11-09T23:44:50.0031590+00:00`

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
  "id": "e96d232a-23ac-4df2-94db-0531562e2894",
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
    "posted_at": "2026-11-09T23:44:50.0031590+00:00"
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
  "subject_id": "b1558b9e-2162-4352-913f-6056ba7897bf",
  "subject_name": "django/db/models/fields/__init__::Field.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```

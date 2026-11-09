# Fact 0ba0cf9d

Store id: ac41159c-c673-40ad-bf73-82c5479ed378

## Text

```text
def validate(self, value, model_instance)
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
- posted_at: `2026-11-09T23:44:50.0086630+00:00`

## Data

```json
{
  "end_line": 867,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 838,
  "symbol": "Field.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":838,"selector":"L838-L867","symbol":"Field.validate"}`

## Items

```json
[
  {
    "text": "Validate value and raise ValidationError if necessary. Subclasses should override this to provide validation logic.",
    "locator": {
      "line": 839
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 867,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 838,
    "symbol": "Field.validate"
  },
  "id": "ac41159c-c673-40ad-bf73-82c5479ed378",
  "items": [
    {
      "locator": {
        "line": 839
      },
      "text": "Validate value and raise ValidationError if necessary. Subclasses should override this to provide validation logic."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0086630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 838,
        "selector": "L838-L867",
        "symbol": "Field.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "23ff5448-7788-4463-955f-4fefc61fef3c",
  "subject_name": "django/db/models/fields/__init__::Field.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

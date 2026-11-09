# Fact 0ba0cf9d

Store id: 5fcabc14-ebee-4024-ba13-294e10584eda

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
- posted_at: `2026-11-09T22:39:42.3148270+00:00`

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
  "id": "5fcabc14-ebee-4024-ba13-294e10584eda",
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
    "posted_at": "2026-11-09T22:39:42.3148270+00:00"
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
  "subject_id": "63d61b5a-1a01-460d-aef2-4c31e30642f8",
  "subject_name": "django/db/models/fields/__init__::Field.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

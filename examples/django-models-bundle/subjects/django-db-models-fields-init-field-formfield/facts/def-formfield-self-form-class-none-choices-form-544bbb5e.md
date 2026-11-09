# Fact 544bbb5e

Store id: 0e55e988-7acf-46a7-afe9-5d071d617382

## Text

```text
def formfield(self, form_class=None, choices_form_class=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.0488460+00:00`

## Data

```json
{
  "end_line": 1189,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1142,
  "symbol": "Field.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1142,"selector":"L1142-L1189","symbol":"Field.formfield"}`

## Items

```json
[
  {
    "text": "Return a django.forms.Field instance for this field.",
    "locator": {
      "line": 1143
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1189,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1142,
    "symbol": "Field.formfield"
  },
  "id": "0e55e988-7acf-46a7-afe9-5d071d617382",
  "items": [
    {
      "locator": {
        "line": 1143
      },
      "text": "Return a django.forms.Field instance for this field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0488460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1142,
        "selector": "L1142-L1189",
        "symbol": "Field.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "acc5af33-d870-415f-ae1b-db820ca4118e",
  "subject_name": "django/db/models/fields/__init__::Field.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, form_class=None, choices_form_class=None, **kwargs)"
}
```

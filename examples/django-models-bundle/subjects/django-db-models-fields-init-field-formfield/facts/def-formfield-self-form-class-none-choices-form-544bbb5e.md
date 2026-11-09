# Fact 544bbb5e

Store id: bd387a8a-5a87-4396-8b8e-1c12e5e43401

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
- posted_at: `2026-11-09T23:31:56.5327130+00:00`

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
  "id": "bd387a8a-5a87-4396-8b8e-1c12e5e43401",
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
    "posted_at": "2026-11-09T23:31:56.5327130+00:00"
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
  "subject_id": "bd086af5-867d-486b-9e4d-942bbdc5813a",
  "subject_name": "django/db/models/fields/__init__::Field.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, form_class=None, choices_form_class=None, **kwargs)"
}
```

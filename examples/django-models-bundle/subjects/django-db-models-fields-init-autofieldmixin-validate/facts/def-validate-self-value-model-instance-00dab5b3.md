# Fact 00dab5b3

Store id: d68a85cd-b8de-452c-a02e-e5524995dade

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
- posted_at: `2026-11-09T22:39:42.7316250+00:00`

## Data

```json
{
  "end_line": 2906,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2905,
  "symbol": "AutoFieldMixin.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2905,"selector":"L2905-L2906","symbol":"AutoFieldMixin.validate"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2906,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2905,
    "symbol": "AutoFieldMixin.validate"
  },
  "id": "d68a85cd-b8de-452c-a02e-e5524995dade",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7316250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2905,
        "selector": "L2905-L2906",
        "symbol": "AutoFieldMixin.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9904419c-a397-408d-8f00-ec9f1151adc9",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

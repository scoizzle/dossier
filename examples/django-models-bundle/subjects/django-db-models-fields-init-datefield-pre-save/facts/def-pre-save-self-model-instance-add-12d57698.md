# Fact 12d57698

Store id: 2cf330b2-608c-4f28-82bc-85bb4cf34f1b

## Text

```text
def pre_save(self, model_instance, add)
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
- posted_at: `2026-11-09T23:31:56.5831150+00:00`

## Data

```json
{
  "end_line": 1556,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1550,
  "symbol": "DateField.pre_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1550,"selector":"L1550-L1556","symbol":"DateField.pre_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.pre_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1556,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1550,
    "symbol": "DateField.pre_save"
  },
  "id": "2cf330b2-608c-4f28-82bc-85bb4cf34f1b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5831150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1550,
        "selector": "L1550-L1556",
        "symbol": "DateField.pre_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5d7852fb-7480-4e52-be9b-be5cfdf221f0",
  "subject_name": "django/db/models/fields/__init__::DateField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

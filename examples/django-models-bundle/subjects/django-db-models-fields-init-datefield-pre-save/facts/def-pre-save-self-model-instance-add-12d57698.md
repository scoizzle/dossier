# Fact 12d57698

Store id: 169658e4-b3c9-4abd-8f6f-30e917b354cf

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
- posted_at: `2026-11-09T23:44:50.0919570+00:00`

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
  "id": "169658e4-b3c9-4abd-8f6f-30e917b354cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0919570+00:00"
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
  "subject_id": "b48fdefb-5a05-4815-82a4-91d9ef78f91c",
  "subject_name": "django/db/models/fields/__init__::DateField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

# Fact 12d57698

Store id: a2638926-d47f-4daa-8720-9d1231033386

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
- posted_at: `2026-11-09T22:39:42.4194910+00:00`

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
  "id": "a2638926-d47f-4daa-8720-9d1231033386",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4194910+00:00"
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
  "subject_id": "e4e93d7f-9e71-44db-acea-13121ee4e141",
  "subject_name": "django/db/models/fields/__init__::DateField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

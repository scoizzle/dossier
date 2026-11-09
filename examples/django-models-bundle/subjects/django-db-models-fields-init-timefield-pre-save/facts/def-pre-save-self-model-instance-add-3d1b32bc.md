# Fact 3d1b32bc

Store id: 431c33da-6f22-466c-ab12-fe388e2f575b

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
- posted_at: `2026-11-09T23:44:50.2602540+00:00`

## Data

```json
{
  "end_line": 2694,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2688,
  "symbol": "TimeField.pre_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2688,"selector":"L2688-L2694","symbol":"TimeField.pre_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.pre_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2694,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2688,
    "symbol": "TimeField.pre_save"
  },
  "id": "431c33da-6f22-466c-ab12-fe388e2f575b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2602540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2688,
        "selector": "L2688-L2694",
        "symbol": "TimeField.pre_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6666a771-33a6-4066-b6b4-88644c4703af",
  "subject_name": "django/db/models/fields/__init__::TimeField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

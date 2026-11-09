# Fact f06aaca2

Store id: 2d43d99b-e681-4798-aa7b-7b62a6a28ce4

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
- posted_at: `2026-11-09T22:39:42.4338430+00:00`

## Data

```json
{
  "end_line": 1696,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1690,
  "symbol": "DateTimeField.pre_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1690,"selector":"L1690-L1696","symbol":"DateTimeField.pre_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.pre_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1696,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1690,
    "symbol": "DateTimeField.pre_save"
  },
  "id": "2d43d99b-e681-4798-aa7b-7b62a6a28ce4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4338430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1690,
        "selector": "L1690-L1696",
        "symbol": "DateTimeField.pre_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e2255347-9f2c-40bf-a82c-01e41ffd3253",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.pre_save",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save(self, model_instance, add)"
}
```

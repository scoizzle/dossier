# Fact d3302e1a

Store id: 50ee3563-34dd-4b47-b829-e0c158ff445b

## Text

```text
def value_to_string(self, obj)
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
- posted_at: `2026-11-09T23:44:50.1341160+00:00`

## Data

```json
{
  "end_line": 1986,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1984,
  "symbol": "DurationField.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1984,"selector":"L1984-L1986","symbol":"DurationField.value_to_string"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1986,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1984,
    "symbol": "DurationField.value_to_string"
  },
  "id": "50ee3563-34dd-4b47-b829-e0c158ff445b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1341160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1984,
        "selector": "L1984-L1986",
        "symbol": "DurationField.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b60a74c4-13f4-4dbb-bb8d-baf9968ca8c5",
  "subject_name": "django/db/models/fields/__init__::DurationField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```

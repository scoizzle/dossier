# Fact 5e434591

Store id: 9dd0a366-344a-4504-954d-39695679e6f0

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
- posted_at: `2026-11-09T23:44:50.9493610+00:00`

## Data

```json
{
  "end_line": 140,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 139,
  "symbol": "JSONField.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":139,"selector":"L139-L140","symbol":"JSONField.value_to_string"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 140,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 139,
    "symbol": "JSONField.value_to_string"
  },
  "id": "9dd0a366-344a-4504-954d-39695679e6f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9493610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 139,
        "selector": "L139-L140",
        "symbol": "JSONField.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "33ced4e1-78f4-45de-a53c-9c56681b45e1",
  "subject_name": "django/db/models/fields/json::JSONField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```

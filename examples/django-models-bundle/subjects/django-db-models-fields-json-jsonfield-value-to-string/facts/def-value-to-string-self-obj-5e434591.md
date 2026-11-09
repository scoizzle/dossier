# Fact 5e434591

Store id: 0ae13cd8-4791-4979-a5ec-bee420138636

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
- posted_at: `2026-11-09T23:31:57.8579650+00:00`

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
  "id": "0ae13cd8-4791-4979-a5ec-bee420138636",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8579650+00:00"
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
  "subject_id": "ec237e89-f03e-48b1-82e3-97add3f4bef5",
  "subject_name": "django/db/models/fields/json::JSONField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```

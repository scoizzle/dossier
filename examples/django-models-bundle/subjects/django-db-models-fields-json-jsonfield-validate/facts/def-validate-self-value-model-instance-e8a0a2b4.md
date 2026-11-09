# Fact e8a0a2b4

Store id: 65d15134-4753-4137-b1aa-8de872ce098d

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
- posted_at: `2026-11-09T23:31:57.8556260+00:00`

## Data

```json
{
  "end_line": 137,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 128,
  "symbol": "JSONField.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":128,"selector":"L128-L137","symbol":"JSONField.validate"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 137,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 128,
    "symbol": "JSONField.validate"
  },
  "id": "65d15134-4753-4137-b1aa-8de872ce098d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8556260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 128,
        "selector": "L128-L137",
        "symbol": "JSONField.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "16854058-9110-4de4-8c3d-1f2dc98a1fce",
  "subject_name": "django/db/models/fields/json::JSONField.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, value, model_instance)"
}
```

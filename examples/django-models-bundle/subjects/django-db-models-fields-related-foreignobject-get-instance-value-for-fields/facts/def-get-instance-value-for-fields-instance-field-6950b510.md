# Fact 6950b510

Store id: 669083d6-d199-4817-9af3-81500a227349

## Text

```text
def get_instance_value_for_fields(instance, fields)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:static_method`, `decorator:staticmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.6994690+00:00`

## Data

```json
{
  "end_line": 848,
  "entity_kind": "static_method",
  "parent": "ForeignObject",
  "start_line": 830,
  "symbol": "ForeignObject.get_instance_value_for_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":830,"selector":"L830-L848","symbol":"ForeignObject.get_instance_value_for_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_instance_value_for_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 848,
    "entity_kind": "static_method",
    "parent": "ForeignObject",
    "start_line": 830,
    "symbol": "ForeignObject.get_instance_value_for_fields"
  },
  "id": "669083d6-d199-4817-9af3-81500a227349",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6994690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 830,
        "selector": "L830-L848",
        "symbol": "ForeignObject.get_instance_value_for_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "10858d6e-a8b3-4235-9fbd-e77e9f7cd8be",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_instance_value_for_fields",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def get_instance_value_for_fields(instance, fields)"
}
```

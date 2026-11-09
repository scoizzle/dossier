# Fact 6950b510

Store id: d4fd3799-91d8-4822-8999-94763b73adb3

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
- posted_at: `2026-11-09T22:39:44.3381440+00:00`

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
  "id": "d4fd3799-91d8-4822-8999-94763b73adb3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3381440+00:00"
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
  "subject_id": "807e0c40-93bf-4e11-b041-9c60ae72c39c",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_instance_value_for_fields",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def get_instance_value_for_fields(instance, fields)"
}
```

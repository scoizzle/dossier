# Fact 5a89f860

Store id: 5d064070-e505-4342-bbe8-9b4c09746322

## Text

```text
def _check_property_name_related_field_accessor_clashes(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.3609590+00:00`

## Data

```json
{
  "end_line": 2149,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2130,
  "symbol": "Model._check_property_name_related_field_accessor_clashes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2130,"selector":"L2130-L2149","symbol":"Model._check_property_name_related_field_accessor_clashes"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_property_name_related_field_accessor_clashes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2149,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2130,
    "symbol": "Model._check_property_name_related_field_accessor_clashes"
  },
  "id": "5d064070-e505-4342-bbe8-9b4c09746322",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3609590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2130,
        "selector": "L2130-L2149",
        "symbol": "Model._check_property_name_related_field_accessor_clashes"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "2e6182c3-53ef-42e3-a092-7c3a435754ba",
  "subject_name": "django/db/models/base::Model._check_property_name_related_field_accessor_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_property_name_related_field_accessor_clashes(cls)"
}
```

# Fact 5a89f860

Store id: b03e6451-2ed6-47fd-a657-67e7022a8610

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
- posted_at: `2026-11-09T23:44:48.5508380+00:00`

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
  "id": "b03e6451-2ed6-47fd-a657-67e7022a8610",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5508380+00:00"
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
  "subject_id": "4bfdae5a-be7d-41cf-8239-1935f9f948dc",
  "subject_name": "django/db/models/base::Model._check_property_name_related_field_accessor_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_property_name_related_field_accessor_clashes(cls)"
}
```

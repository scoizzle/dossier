# Fact 5a89f860

Store id: f2494007-b327-4bfc-91ea-9dc42ac01bf0

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
- posted_at: `2026-11-09T23:31:53.7658740+00:00`

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
  "id": "f2494007-b327-4bfc-91ea-9dc42ac01bf0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7658740+00:00"
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
  "subject_id": "36b066df-f4ee-4c11-a481-ebede2f59e2f",
  "subject_name": "django/db/models/base::Model._check_property_name_related_field_accessor_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_property_name_related_field_accessor_clashes(cls)"
}
```

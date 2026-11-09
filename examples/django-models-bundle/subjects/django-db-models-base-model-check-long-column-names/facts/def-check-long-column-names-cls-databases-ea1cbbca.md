# Fact ea1cbbca

Store id: 33ceabc1-5533-454b-972d-6e21fb4f0b57

## Text

```text
def _check_long_column_names(cls, databases)
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
- posted_at: `2026-11-09T22:39:40.3641570+00:00`

## Data

```json
{
  "end_line": 2472,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2394,
  "symbol": "Model._check_long_column_names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2394,"selector":"L2394-L2472","symbol":"Model._check_long_column_names"}`

## Items

```json
[
  {
    "text": "Check that any auto-generated column names are shorter than the limits for each database in which the model will be created.",
    "locator": {
      "line": 2396
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_long_column_names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2472,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2394,
    "symbol": "Model._check_long_column_names"
  },
  "id": "33ceabc1-5533-454b-972d-6e21fb4f0b57",
  "items": [
    {
      "locator": {
        "line": 2396
      },
      "text": "Check that any auto-generated column names are shorter than the limits for each database in which the model will be created."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3641570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2394,
        "selector": "L2394-L2472",
        "symbol": "Model._check_long_column_names"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "22940827-c7ec-43c3-bb39-6d283b4ae385",
  "subject_name": "django/db/models/base::Model._check_long_column_names",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_long_column_names(cls, databases)"
}
```

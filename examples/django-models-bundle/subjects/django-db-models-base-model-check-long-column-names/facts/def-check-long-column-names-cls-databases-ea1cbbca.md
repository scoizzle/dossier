# Fact ea1cbbca

Store id: 9fc8be7d-2d81-4a89-bda0-823a1957b1d8

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
- posted_at: `2026-11-09T23:31:53.7687610+00:00`

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
  "id": "9fc8be7d-2d81-4a89-bda0-823a1957b1d8",
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
    "posted_at": "2026-11-09T23:31:53.7687610+00:00"
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
  "subject_id": "410ffebb-4936-44ce-bf9c-98582daca7ac",
  "subject_name": "django/db/models/base::Model._check_long_column_names",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_long_column_names(cls, databases)"
}
```

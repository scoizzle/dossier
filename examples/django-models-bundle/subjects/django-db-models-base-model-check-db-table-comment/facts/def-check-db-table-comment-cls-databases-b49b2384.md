# Fact b49b2384

Store id: 0feb1501-127f-4477-a97a-8aa2d6f5eddc

## Text

```text
def _check_db_table_comment(cls, databases)
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
- posted_at: `2026-11-09T23:31:53.7614490+00:00`

## Data

```json
{
  "end_line": 1893,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1872,
  "symbol": "Model._check_db_table_comment"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1872,"selector":"L1872-L1893","symbol":"Model._check_db_table_comment"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_db_table_comment](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1893,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1872,
    "symbol": "Model._check_db_table_comment"
  },
  "id": "0feb1501-127f-4477-a97a-8aa2d6f5eddc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7614490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1872,
        "selector": "L1872-L1893",
        "symbol": "Model._check_db_table_comment"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "7bba7365-c8bd-4a7b-bd5a-a2999c977f33",
  "subject_name": "django/db/models/base::Model._check_db_table_comment",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_db_table_comment(cls, databases)"
}
```

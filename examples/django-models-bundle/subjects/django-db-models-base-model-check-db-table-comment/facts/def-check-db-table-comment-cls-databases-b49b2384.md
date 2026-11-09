# Fact b49b2384

Store id: 873cb8a4-79a1-4b39-89cf-50800d0a0897

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
- posted_at: `2026-11-09T23:44:48.5469190+00:00`

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
  "id": "873cb8a4-79a1-4b39-89cf-50800d0a0897",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5469190+00:00"
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
  "subject_id": "6f45f3b2-6656-42c3-9335-ed7716b5f04c",
  "subject_name": "django/db/models/base::Model._check_db_table_comment",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_db_table_comment(cls, databases)"
}
```

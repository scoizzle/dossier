# Fact c3630de7

Store id: f8b59ad3-d768-4e5b-a389-695e73d7092a

## Text

```text
def _get_expr_references(cls, expr)
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
- posted_at: `2026-11-09T23:31:53.7731990+00:00`

## Data

```json
{
  "end_line": 2511,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2497,
  "symbol": "Model._get_expr_references"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2497,"selector":"L2497-L2511","symbol":"Model._get_expr_references"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_expr_references](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2511,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2497,
    "symbol": "Model._get_expr_references"
  },
  "id": "f8b59ad3-d768-4e5b-a389-695e73d7092a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7731990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2497,
        "selector": "L2497-L2511",
        "symbol": "Model._get_expr_references"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "063de4f4-1581-489a-aa12-4f0d95e07e8d",
  "subject_name": "django/db/models/base::Model._get_expr_references",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _get_expr_references(cls, expr)"
}
```

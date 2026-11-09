# Fact c3630de7

Store id: bd644f0e-7dc0-42ce-8c60-358eab1e7c1c

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
- posted_at: `2026-11-09T22:39:40.3673630+00:00`

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
  "id": "bd644f0e-7dc0-42ce-8c60-358eab1e7c1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3673630+00:00"
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
  "subject_id": "53a98a12-8737-4433-be8e-086e650f8eed",
  "subject_name": "django/db/models/base::Model._get_expr_references",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _get_expr_references(cls, expr)"
}
```

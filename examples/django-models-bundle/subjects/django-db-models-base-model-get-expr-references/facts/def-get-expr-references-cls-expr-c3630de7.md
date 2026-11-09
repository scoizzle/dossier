# Fact c3630de7

Store id: 7230fd04-9a14-4c6b-9342-78422eb16a55

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
- posted_at: `2026-11-09T23:44:48.5557220+00:00`

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
  "id": "7230fd04-9a14-4c6b-9342-78422eb16a55",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5557220+00:00"
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
  "subject_id": "c8c5ea3e-692a-457f-b707-fbbad774c359",
  "subject_name": "django/db/models/base::Model._get_expr_references",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _get_expr_references(cls, expr)"
}
```

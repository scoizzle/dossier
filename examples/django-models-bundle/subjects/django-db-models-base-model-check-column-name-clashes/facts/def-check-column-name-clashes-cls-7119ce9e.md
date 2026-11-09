# Fact 7119ce9e

Store id: eb227599-4120-4885-a071-f8af5e55afba

## Text

```text
def _check_column_name_clashes(cls)
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
- posted_at: `2026-11-09T23:31:53.7650690+00:00`

## Data

```json
{
  "end_line": 2104,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2080,
  "symbol": "Model._check_column_name_clashes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2080,"selector":"L2080-L2104","symbol":"Model._check_column_name_clashes"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_column_name_clashes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2104,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2080,
    "symbol": "Model._check_column_name_clashes"
  },
  "id": "eb227599-4120-4885-a071-f8af5e55afba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7650690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2080,
        "selector": "L2080-L2104",
        "symbol": "Model._check_column_name_clashes"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "7cd11782-7359-4e7a-87a8-b7ade28e8d87",
  "subject_name": "django/db/models/base::Model._check_column_name_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_column_name_clashes(cls)"
}
```

# Fact 7119ce9e

Store id: 2ed84868-743e-49e2-8128-47ef8185e8ca

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
- posted_at: `2026-11-09T23:44:48.5500590+00:00`

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
  "id": "2ed84868-743e-49e2-8128-47ef8185e8ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5500590+00:00"
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
  "subject_id": "6dd8d098-c25c-4b85-a539-951233bbd892",
  "subject_name": "django/db/models/base::Model._check_column_name_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_column_name_clashes(cls)"
}
```

# Fact d43069d3

Store id: 669d4c35-0e5c-4e79-b571-f7b2caa14fd2

## Text

```text
def _check_related_fields(cls)
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
- posted_at: `2026-11-09T23:31:53.7715650+00:00`

## Data

```json
{
  "end_line": 2495,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2474,
  "symbol": "Model._check_related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2474,"selector":"L2474-L2495","symbol":"Model._check_related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2495,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2474,
    "symbol": "Model._check_related_fields"
  },
  "id": "669d4c35-0e5c-4e79-b571-f7b2caa14fd2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7715650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2474,
        "selector": "L2474-L2495",
        "symbol": "Model._check_related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "7c9eb294-3792-4afc-9b22-680e1a749175",
  "subject_name": "django/db/models/base::Model._check_related_fields",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_related_fields(cls)"
}
```

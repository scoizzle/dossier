# Fact 81c9272f

Store id: eaa5d91c-9b57-4f72-a64d-05bafce09fea

## Text

```text
def _check_field_name_clashes(cls)
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
- posted_at: `2026-11-09T22:39:40.3595730+00:00`

## Data

```json
{
  "end_line": 2078,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2010,
  "symbol": "Model._check_field_name_clashes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2010,"selector":"L2010-L2078","symbol":"Model._check_field_name_clashes"}`

## Items

```json
[
  {
    "text": "Forbid field shadowing in multi-table inheritance.",
    "locator": {
      "line": 2012
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_field_name_clashes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2078,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2010,
    "symbol": "Model._check_field_name_clashes"
  },
  "id": "eaa5d91c-9b57-4f72-a64d-05bafce09fea",
  "items": [
    {
      "locator": {
        "line": 2012
      },
      "text": "Forbid field shadowing in multi-table inheritance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3595730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2010,
        "selector": "L2010-L2078",
        "symbol": "Model._check_field_name_clashes"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "2558b961-48bc-45e8-8652-ae8e10916c6c",
  "subject_name": "django/db/models/base::Model._check_field_name_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_field_name_clashes(cls)"
}
```

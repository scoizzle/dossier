# Fact 7a1e2a90

Store id: cafaedc7-c968-4362-9054-01894b00d740

## Text

```text
def _check_managers(cls, **kwargs)
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
- posted_at: `2026-11-09T22:39:40.3574150+00:00`

## Data

```json
{
  "end_line": 1941,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1935,
  "symbol": "Model._check_managers"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1935,"selector":"L1935-L1941","symbol":"Model._check_managers"}`

## Items

```json
[
  {
    "text": "Perform all manager checks.",
    "locator": {
      "line": 1937
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_managers](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1941,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1935,
    "symbol": "Model._check_managers"
  },
  "id": "cafaedc7-c968-4362-9054-01894b00d740",
  "items": [
    {
      "locator": {
        "line": 1937
      },
      "text": "Perform all manager checks."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3574150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1935,
        "selector": "L1935-L1941",
        "symbol": "Model._check_managers"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "d38d32f7-c6b8-43aa-a588-8203a761e77d",
  "subject_name": "django/db/models/base::Model._check_managers",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_managers(cls, **kwargs)"
}
```

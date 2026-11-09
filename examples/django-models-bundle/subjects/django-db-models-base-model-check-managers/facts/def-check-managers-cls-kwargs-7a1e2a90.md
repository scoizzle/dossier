# Fact 7a1e2a90

Store id: 31f209ad-6691-4a3a-a9e3-f5b21764e2fb

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
- posted_at: `2026-11-09T23:44:48.5480840+00:00`

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
  "id": "31f209ad-6691-4a3a-a9e3-f5b21764e2fb",
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
    "posted_at": "2026-11-09T23:44:48.5480840+00:00"
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
  "subject_id": "fd207ac4-8687-41c8-868c-6554bf9d145c",
  "subject_name": "django/db/models/base::Model._check_managers",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_managers(cls, **kwargs)"
}
```

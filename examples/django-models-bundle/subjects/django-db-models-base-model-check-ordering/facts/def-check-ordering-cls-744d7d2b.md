# Fact 744d7d2b

Store id: 82362d7e-c80c-42a4-b67f-cdebe6d12968

## Text

```text
def _check_ordering(cls)
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
- posted_at: `2026-11-09T22:39:40.3636220+00:00`

## Data

```json
{
  "end_line": 2392,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2285,
  "symbol": "Model._check_ordering"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2285,"selector":"L2285-L2392","symbol":"Model._check_ordering"}`

## Items

```json
[
  {
    "text": "Check \"ordering\" option -- is it a list of strings and do all fields exist?",
    "locator": {
      "line": 2287
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_ordering](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2392,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2285,
    "symbol": "Model._check_ordering"
  },
  "id": "82362d7e-c80c-42a4-b67f-cdebe6d12968",
  "items": [
    {
      "locator": {
        "line": 2287
      },
      "text": "Check \"ordering\" option -- is it a list of strings and do all fields exist?"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3636220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2285,
        "selector": "L2285-L2392",
        "symbol": "Model._check_ordering"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "07afefd3-68ec-47c7-8d03-a7d81170002a",
  "subject_name": "django/db/models/base::Model._check_ordering",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_ordering(cls)"
}
```

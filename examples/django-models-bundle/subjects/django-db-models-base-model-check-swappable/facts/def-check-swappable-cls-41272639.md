# Fact 41272639

Store id: 0113f8bb-97f2-48cf-979b-8cd943229871

## Text

```text
def _check_swappable(cls)
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
- posted_at: `2026-11-09T22:39:40.3556750+00:00`

## Data

```json
{
  "end_line": 1920,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1895,
  "symbol": "Model._check_swappable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1895,"selector":"L1895-L1920","symbol":"Model._check_swappable"}`

## Items

```json
[
  {
    "text": "Check if the swapped model exists.",
    "locator": {
      "line": 1897
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_swappable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1920,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1895,
    "symbol": "Model._check_swappable"
  },
  "id": "0113f8bb-97f2-48cf-979b-8cd943229871",
  "items": [
    {
      "locator": {
        "line": 1897
      },
      "text": "Check if the swapped model exists."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3556750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1895,
        "selector": "L1895-L1920",
        "symbol": "Model._check_swappable"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "0600edca-c689-4121-bf1a-e8dd3e0d24bc",
  "subject_name": "django/db/models/base::Model._check_swappable",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_swappable(cls)"
}
```

# Fact 41272639

Store id: e5f1be3c-60ef-4e1b-9c88-67885336c296

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
- posted_at: `2026-11-09T23:31:53.7619790+00:00`

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
  "id": "e5f1be3c-60ef-4e1b-9c88-67885336c296",
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
    "posted_at": "2026-11-09T23:31:53.7619790+00:00"
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
  "subject_id": "9f121157-2a8a-4574-95c4-05f125acf93d",
  "subject_name": "django/db/models/base::Model._check_swappable",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_swappable(cls)"
}
```

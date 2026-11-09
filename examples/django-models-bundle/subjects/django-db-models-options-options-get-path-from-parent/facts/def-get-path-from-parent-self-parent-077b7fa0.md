# Fact 077b7fa0

Store id: 1afa8664-d222-4f30-8626-9e49389fe6ad

## Text

```text
def get_path_from_parent(self, parent)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.0197560+00:00`

## Data

```json
{
  "end_line": 806,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 786,
  "symbol": "Options.get_path_from_parent"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":786,"selector":"L786-L806","symbol":"Options.get_path_from_parent"}`

## Items

```json
[
  {
    "text": "Return a list of PathInfos containing the path from the parent model to the current model, or an empty list if parent is not a parent of the current model.",
    "locator": {
      "line": 787
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.get_path_from_parent](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 806,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 786,
    "symbol": "Options.get_path_from_parent"
  },
  "id": "1afa8664-d222-4f30-8626-9e49389fe6ad",
  "items": [
    {
      "locator": {
        "line": 787
      },
      "text": "Return a list of PathInfos containing the path from the parent model to the current model, or an empty list if parent is not a parent of the current model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.0197560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 786,
        "selector": "L786-L806",
        "symbol": "Options.get_path_from_parent"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "a76275df-914a-4f10-a288-099c8ea7c588",
  "subject_name": "django/db/models/options::Options.get_path_from_parent",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_from_parent(self, parent)"
}
```

# Fact 41272639

Store id: 49578eae-52c4-48ae-a132-6ab8e71d19a4

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
- posted_at: `2026-11-09T23:44:48.5473110+00:00`

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
  "id": "49578eae-52c4-48ae-a132-6ab8e71d19a4",
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
    "posted_at": "2026-11-09T23:44:48.5473110+00:00"
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
  "subject_id": "d7d7afda-ffa6-4d90-b9fb-9fed722885f5",
  "subject_name": "django/db/models/base::Model._check_swappable",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_swappable(cls)"
}
```

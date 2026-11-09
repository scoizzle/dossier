# Fact e16baad1

Store id: b2e1f2a5-baf6-4bbc-8f79-f702e0807b92

## Text

```text
def get_path_to_parent(self, parent)
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
- posted_at: `2026-11-09T22:39:48.8890940+00:00`

## Data

```json
{
  "end_line": 784,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 754,
  "symbol": "Options.get_path_to_parent"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":754,"selector":"L754-L784","symbol":"Options.get_path_to_parent"}`

## Items

```json
[
  {
    "text": "Return a list of PathInfos containing the path from the current model to the parent model, or an empty list if parent is not a parent of the current model.",
    "locator": {
      "line": 755
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.get_path_to_parent](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 784,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 754,
    "symbol": "Options.get_path_to_parent"
  },
  "id": "b2e1f2a5-baf6-4bbc-8f79-f702e0807b92",
  "items": [
    {
      "locator": {
        "line": 755
      },
      "text": "Return a list of PathInfos containing the path from the current model to the parent model, or an empty list if parent is not a parent of the current model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8890940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 754,
        "selector": "L754-L784",
        "symbol": "Options.get_path_to_parent"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "be6c4d74-1159-4a25-aee1-80185267ab7f",
  "subject_name": "django/db/models/options::Options.get_path_to_parent",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_to_parent(self, parent)"
}
```

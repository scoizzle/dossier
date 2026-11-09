# Fact 077b7fa0

Store id: b537b85a-3cf8-40bd-b180-7729b54ca18f

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
- posted_at: `2026-11-09T23:44:55.5690500+00:00`

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
  "id": "b537b85a-3cf8-40bd-b180-7729b54ca18f",
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
    "posted_at": "2026-11-09T23:44:55.5690500+00:00"
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
  "subject_id": "e42447b5-67e7-4d25-aa9d-7719ea0f4a38",
  "subject_name": "django/db/models/options::Options.get_path_from_parent",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_from_parent(self, parent)"
}
```

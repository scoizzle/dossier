# Fact e16baad1

Store id: 72fbbf93-877b-473a-9a92-2c5b08202e31

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
- posted_at: `2026-11-09T23:32:04.0165820+00:00`

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
  "id": "72fbbf93-877b-473a-9a92-2c5b08202e31",
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
    "posted_at": "2026-11-09T23:32:04.0165820+00:00"
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
  "subject_id": "d3edbcfe-ee3c-4787-b813-765c14407dc1",
  "subject_name": "django/db/models/options::Options.get_path_to_parent",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_to_parent(self, parent)"
}
```

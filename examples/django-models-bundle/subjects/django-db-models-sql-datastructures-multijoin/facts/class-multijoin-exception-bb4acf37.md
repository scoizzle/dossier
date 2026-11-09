# Fact bb4acf37

Store id: 92c2fd3a-c20a-466d-983a-0a03a28211fd

## Text

```text
class MultiJoin(Exception)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:06.4111740+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "class",
  "parent": "datastructures",
  "start_line": 10,
  "symbol": "MultiJoin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"selector":"L10-L20","symbol":"MultiJoin"}`

## Items

```json
[
  {
    "text": "Used by join construction code to indicate the point at which a multi-valued join was attempted (if the caller wants to treat that exceptionally).",
    "locator": {
      "line": 11
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::MultiJoin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "class",
    "parent": "datastructures",
    "start_line": 10,
    "symbol": "MultiJoin"
  },
  "id": "92c2fd3a-c20a-466d-983a-0a03a28211fd",
  "items": [
    {
      "locator": {
        "line": 11
      },
      "text": "Used by join construction code to indicate the point at which a multi-valued join was attempted (if the caller wants to treat that exceptionally)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4111740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 10,
        "selector": "L10-L20",
        "symbol": "MultiJoin"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "5fd8ab27-3e8d-4e30-9918-9d57542df189",
  "subject_name": "django/db/models/sql/datastructures::MultiJoin",
  "tags": [
    "entity:class"
  ],
  "text": "class MultiJoin(Exception)"
}
```

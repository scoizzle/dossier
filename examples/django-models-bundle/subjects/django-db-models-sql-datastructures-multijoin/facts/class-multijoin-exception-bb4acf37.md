# Fact bb4acf37

Store id: f8e2ab5b-aece-4251-801a-6dd1985afc23

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
- posted_at: `2026-11-09T22:39:50.9496040+00:00`

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
  "id": "f8e2ab5b-aece-4251-801a-6dd1985afc23",
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
    "posted_at": "2026-11-09T22:39:50.9496040+00:00"
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
  "subject_id": "997366a3-57e3-4618-bc97-0ac3e4c20784",
  "subject_name": "django/db/models/sql/datastructures::MultiJoin",
  "tags": [
    "entity:class"
  ],
  "text": "class MultiJoin(Exception)"
}
```

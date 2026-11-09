# Fact bb4acf37

Store id: de58b7f7-d780-4cb8-b357-479f09f32a10

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
- posted_at: `2026-11-09T23:44:58.1442500+00:00`

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
  "id": "de58b7f7-d780-4cb8-b357-479f09f32a10",
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
    "posted_at": "2026-11-09T23:44:58.1442500+00:00"
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
  "subject_id": "daf160c2-5f9b-4ff7-b13b-1dc0f43761a2",
  "subject_name": "django/db/models/sql/datastructures::MultiJoin",
  "tags": [
    "entity:class"
  ],
  "text": "class MultiJoin(Exception)"
}
```

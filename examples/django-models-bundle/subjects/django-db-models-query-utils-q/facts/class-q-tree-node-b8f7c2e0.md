# Fact b8f7c2e0

Store id: 3b01ac34-d3c7-436f-af51-b028be2acf4c

## Text

```text
class Q(tree.Node)
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
- posted_at: `2026-11-09T23:32:05.0258630+00:00`

## Data

```json
{
  "end_line": 247,
  "entity_kind": "class",
  "parent": "query_utils",
  "start_line": 41,
  "symbol": "Q"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":41,"selector":"L41-L247","symbol":"Q"}`

## Items

```json
[
  {
    "text": "Encapsulate filters as objects that can then be combined logically (using `&` and `|`).",
    "locator": {
      "line": 42
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 247,
    "entity_kind": "class",
    "parent": "query_utils",
    "start_line": 41,
    "symbol": "Q"
  },
  "id": "3b01ac34-d3c7-436f-af51-b028be2acf4c",
  "items": [
    {
      "locator": {
        "line": 42
      },
      "text": "Encapsulate filters as objects that can then be combined logically (using `&` and `|`)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0258630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 41,
        "selector": "L41-L247",
        "symbol": "Q"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "c902221d-bb84-4c1f-9d7a-aa5b046cb03c",
  "subject_name": "django/db/models/query_utils::Q",
  "tags": [
    "entity:class"
  ],
  "text": "class Q(tree.Node)"
}
```

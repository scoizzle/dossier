# Fact 2100b016

Store id: 977d9f27-a402-46b6-b628-ba9171df263b

## Text

```text
class NothingNode
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
- posted_at: `2026-11-09T22:39:51.9822640+00:00`

## Data

```json
{
  "end_line": 331,
  "entity_kind": "class",
  "parent": "where",
  "start_line": 324,
  "symbol": "NothingNode"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":324,"selector":"L324-L331","symbol":"NothingNode"}`

## Items

```json
[
  {
    "text": "A node that matches nothing.",
    "locator": {
      "line": 325
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/where::NothingNode](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 331,
    "entity_kind": "class",
    "parent": "where",
    "start_line": 324,
    "symbol": "NothingNode"
  },
  "id": "977d9f27-a402-46b6-b628-ba9171df263b",
  "items": [
    {
      "locator": {
        "line": 325
      },
      "text": "A node that matches nothing."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9822640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 324,
        "selector": "L324-L331",
        "symbol": "NothingNode"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "e4aa66c3-be3e-4ba9-8fb2-a2b83005d779",
  "subject_name": "django/db/models/sql/where::NothingNode",
  "tags": [
    "entity:class"
  ],
  "text": "class NothingNode"
}
```

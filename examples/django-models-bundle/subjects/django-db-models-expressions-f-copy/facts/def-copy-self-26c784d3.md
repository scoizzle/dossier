# Fact 26c784d3

Store id: ed7da44c-0c3c-4cdb-9c6b-5e36a3ba08e1

## Text

```text
def copy(self)
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
- posted_at: `2026-11-09T22:39:41.5666890+00:00`

## Data

```json
{
  "end_line": 943,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 942,
  "symbol": "F.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":942,"selector":"L942-L943","symbol":"F.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 943,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 942,
    "symbol": "F.copy"
  },
  "id": "ed7da44c-0c3c-4cdb-9c6b-5e36a3ba08e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5666890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 942,
        "selector": "L942-L943",
        "symbol": "F.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f5d176c2-a3f8-4821-b0b1-7dda9c5cc297",
  "subject_name": "django/db/models/expressions::F.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```

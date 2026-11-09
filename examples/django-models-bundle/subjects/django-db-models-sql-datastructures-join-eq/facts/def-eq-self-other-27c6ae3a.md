# Fact 27c6ae3a

Store id: 3b3946f9-85db-4ece-a149-ec133c0486f5

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:58.2239350+00:00`

## Data

```json
{
  "end_line": 165,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 162,
  "symbol": "Join.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":162,"selector":"L162-L165","symbol":"Join.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 165,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 162,
    "symbol": "Join.__eq__"
  },
  "id": "3b3946f9-85db-4ece-a149-ec133c0486f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.2239350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 162,
        "selector": "L162-L165",
        "symbol": "Join.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "a9c7f3da-8c58-41a8-aa4b-1f0b6e789935",
  "subject_name": "django/db/models/sql/datastructures::Join.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```

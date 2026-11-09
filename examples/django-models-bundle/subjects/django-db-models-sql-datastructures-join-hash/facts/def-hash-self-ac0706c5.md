# Fact ac0706c5

Store id: 6b561747-2d4a-4fb7-892a-b90c4e7f9347

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:32:06.4687040+00:00`

## Data

```json
{
  "end_line": 168,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 167,
  "symbol": "Join.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":167,"selector":"L167-L168","symbol":"Join.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 168,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 167,
    "symbol": "Join.__hash__"
  },
  "id": "6b561747-2d4a-4fb7-892a-b90c4e7f9347",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4687040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 167,
        "selector": "L167-L168",
        "symbol": "Join.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "2d0a9bd4-1bb4-4d20-8fc1-22f55db661ef",
  "subject_name": "django/db/models/sql/datastructures::Join.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```

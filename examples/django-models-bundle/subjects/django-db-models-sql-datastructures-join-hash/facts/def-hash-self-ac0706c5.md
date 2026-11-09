# Fact ac0706c5

Store id: dc43f3f0-7a36-42e1-84dc-a3c8567ac08c

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
- posted_at: `2026-11-09T22:39:51.0011980+00:00`

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
  "id": "dc43f3f0-7a36-42e1-84dc-a3c8567ac08c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0011980+00:00"
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
  "subject_id": "7e2e3aff-9da1-487d-af9d-1385d062a7f7",
  "subject_name": "django/db/models/sql/datastructures::Join.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```

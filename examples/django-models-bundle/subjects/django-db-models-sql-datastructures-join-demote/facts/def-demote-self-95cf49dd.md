# Fact 95cf49dd

Store id: fdd87af9-fc21-49cd-ae13-da0b49b8e95d

## Text

```text
def demote(self)
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
- posted_at: `2026-11-09T22:39:51.0046510+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 170,
  "symbol": "Join.demote"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":170,"selector":"L170-L173","symbol":"Join.demote"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.demote](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 170,
    "symbol": "Join.demote"
  },
  "id": "fdd87af9-fc21-49cd-ae13-da0b49b8e95d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0046510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 170,
        "selector": "L170-L173",
        "symbol": "Join.demote"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "e8c96db1-42f7-4942-9a78-d8a8cfaf9518",
  "subject_name": "django/db/models/sql/datastructures::Join.demote",
  "tags": [
    "entity:method"
  ],
  "text": "def demote(self)"
}
```

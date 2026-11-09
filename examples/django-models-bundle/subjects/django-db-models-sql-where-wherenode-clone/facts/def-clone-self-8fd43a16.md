# Fact 8fd43a16

Store id: 875d078c-87bb-447a-9917-a1ee4027c3b9

## Text

```text
def clone(self)
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
- posted_at: `2026-11-09T22:39:51.9236680+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 217,
  "symbol": "WhereNode.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":217,"selector":"L217-L223","symbol":"WhereNode.clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 217,
    "symbol": "WhereNode.clone"
  },
  "id": "875d078c-87bb-447a-9917-a1ee4027c3b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9236680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 217,
        "selector": "L217-L223",
        "symbol": "WhereNode.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "7c840a62-26f4-4870-ae56-1cc57aec2d30",
  "subject_name": "django/db/models/sql/where::WhereNode.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```

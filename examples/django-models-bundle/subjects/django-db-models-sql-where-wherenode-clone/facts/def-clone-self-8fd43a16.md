# Fact 8fd43a16

Store id: fed62d02-50e5-45f5-b21f-775a702e3850

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
- posted_at: `2026-11-09T23:44:59.7336210+00:00`

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
  "id": "fed62d02-50e5-45f5-b21f-775a702e3850",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7336210+00:00"
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
  "subject_id": "cbe04aa2-60ed-4600-8717-345d94d1073e",
  "subject_name": "django/db/models/sql/where::WhereNode.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```

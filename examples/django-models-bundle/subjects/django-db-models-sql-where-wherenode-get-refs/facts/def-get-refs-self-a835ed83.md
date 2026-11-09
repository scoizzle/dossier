# Fact a835ed83

Store id: 0e485f48-4a09-48f2-97df-e13e600fc7e8

## Text

```text
def get_refs(self)
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
- posted_at: `2026-11-09T23:32:07.6353400+00:00`

## Data

```json
{
  "end_line": 244,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 240,
  "symbol": "WhereNode.get_refs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":240,"selector":"L240-L244","symbol":"WhereNode.get_refs"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.get_refs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 244,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 240,
    "symbol": "WhereNode.get_refs"
  },
  "id": "0e485f48-4a09-48f2-97df-e13e600fc7e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6353400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 240,
        "selector": "L240-L244",
        "symbol": "WhereNode.get_refs"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "1b8eee92-3f83-44fb-8e2d-35d5af01535f",
  "subject_name": "django/db/models/sql/where::WhereNode.get_refs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_refs(self)"
}
```

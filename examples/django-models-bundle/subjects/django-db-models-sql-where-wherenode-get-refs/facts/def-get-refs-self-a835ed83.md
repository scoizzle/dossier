# Fact a835ed83

Store id: 13ba3e49-9d16-47dd-a02f-27869338e5e8

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
- posted_at: `2026-11-09T23:44:59.7487440+00:00`

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
  "id": "13ba3e49-9d16-47dd-a02f-27869338e5e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7487440+00:00"
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
  "subject_id": "fb980507-c377-46c0-989c-c90f30f6fa38",
  "subject_name": "django/db/models/sql/where::WhereNode.get_refs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_refs(self)"
}
```

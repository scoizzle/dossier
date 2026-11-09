# Fact a835ed83

Store id: 2d61ff36-c428-49e2-b914-6a47043e4271

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
- posted_at: `2026-11-09T22:39:51.9331940+00:00`

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
  "id": "2d61ff36-c428-49e2-b914-6a47043e4271",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9331940+00:00"
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
  "subject_id": "9b5fb5bc-7333-4ca5-9c65-7604064b9be8",
  "subject_name": "django/db/models/sql/where::WhereNode.get_refs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_refs(self)"
}
```

# Fact dbc38ac3

Store id: 81915d8c-94fc-4628-9536-4a5763791034

## Text

```text
def get_related_populators(klass_info, select, db, fetch_mode)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.9120100+00:00`

## Data

```json
{
  "end_line": 3096,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 3090,
  "symbol": "get_related_populators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":3090,"selector":"L3090-L3096","symbol":"get_related_populators"}`

## Referenced by

None.

## Subject

[django/db/models/query::get_related_populators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 3096,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 3090,
    "symbol": "get_related_populators"
  },
  "id": "81915d8c-94fc-4628-9536-4a5763791034",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.9120100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 3090,
        "selector": "L3090-L3096",
        "symbol": "get_related_populators"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a5fff49c-0bfb-4516-afd7-c689946e9fbf",
  "subject_name": "django/db/models/query::get_related_populators",
  "tags": [
    "entity:function"
  ],
  "text": "def get_related_populators(klass_info, select, db, fetch_mode)"
}
```

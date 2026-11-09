# Fact bc7d3508

Store id: 74232b8e-3ea7-4d8c-8c4e-2d7ded5e409b

## Text

```text
async def abulk_update(self, objs, fields, batch_size=None)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.4351400+00:00`

## Data

```json
{
  "end_line": 1056,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1051,
  "symbol": "QuerySet.abulk_update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1051,"selector":"L1051-L1056","symbol":"QuerySet.abulk_update"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.abulk_update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1056,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1051,
    "symbol": "QuerySet.abulk_update"
  },
  "id": "74232b8e-3ea7-4d8c-8c4e-2d7ded5e409b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4351400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1051,
        "selector": "L1051-L1056",
        "symbol": "QuerySet.abulk_update"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e8b5a9df-242e-4367-972a-0b12edb37910",
  "subject_name": "django/db/models/query::QuerySet.abulk_update",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def abulk_update(self, objs, fields, batch_size=None)"
}
```

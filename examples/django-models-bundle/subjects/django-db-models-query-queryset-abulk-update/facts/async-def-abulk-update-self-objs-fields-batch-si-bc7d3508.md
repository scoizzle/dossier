# Fact bc7d3508

Store id: f9f8359d-31bd-41dd-88a0-d2cc1f23b6ae

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
- posted_at: `2026-11-09T23:32:04.4147520+00:00`

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
  "id": "f9f8359d-31bd-41dd-88a0-d2cc1f23b6ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4147520+00:00"
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
  "subject_id": "83ba1e6a-8731-4d28-949b-c0c76c0e57c6",
  "subject_name": "django/db/models/query::QuerySet.abulk_update",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def abulk_update(self, objs, fields, batch_size=None)"
}
```

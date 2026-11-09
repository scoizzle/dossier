# Fact bc7d3508

Store id: 091d2b72-bb6b-4e8a-8ef2-3e98c0055b11

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
- posted_at: `2026-11-09T23:44:55.9224630+00:00`

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
  "id": "091d2b72-bb6b-4e8a-8ef2-3e98c0055b11",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9224630+00:00"
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
  "subject_id": "fa4e3643-6ab1-47d8-b29b-61ee99de4420",
  "subject_name": "django/db/models/query::QuerySet.abulk_update",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def abulk_update(self, objs, fields, batch_size=None)"
}
```

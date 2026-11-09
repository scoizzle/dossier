# Fact 0dd63163

Store id: 626bb664-817a-46e8-bd6e-a8ac3156eb70

## Text

```text
async def abulk_create( self, objs, batch_size=None, ignore_conflicts=False, update_conflicts=False, update_fields=None, unique_fields=None, )
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
- posted_at: `2026-11-09T23:32:04.4091360+00:00`

## Data

```json
{
  "end_line": 987,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 971,
  "symbol": "QuerySet.abulk_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":971,"selector":"L971-L987","symbol":"QuerySet.abulk_create"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.abulk_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 987,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 971,
    "symbol": "QuerySet.abulk_create"
  },
  "id": "626bb664-817a-46e8-bd6e-a8ac3156eb70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4091360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 971,
        "selector": "L971-L987",
        "symbol": "QuerySet.abulk_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "950640ac-3364-4765-9d52-c3124a1f3b41",
  "subject_name": "django/db/models/query::QuerySet.abulk_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def abulk_create( self, objs, batch_size=None, ignore_conflicts=False, update_conflicts=False, update_fields=None, unique_fields=None, )"
}
```

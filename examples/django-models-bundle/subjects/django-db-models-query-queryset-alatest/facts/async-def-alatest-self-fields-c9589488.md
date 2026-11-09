# Fact c9589488

Store id: 6aea2d9a-6c31-4b0b-9b59-b57b154b2529

## Text

```text
async def alatest(self, *fields)
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
- posted_at: `2026-11-09T22:39:49.4769980+00:00`

## Data

```json
{
  "end_line": 1219,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1218,
  "symbol": "QuerySet.alatest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1218,"selector":"L1218-L1219","symbol":"QuerySet.alatest"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.alatest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1219,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1218,
    "symbol": "QuerySet.alatest"
  },
  "id": "6aea2d9a-6c31-4b0b-9b59-b57b154b2529",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4769980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1218,
        "selector": "L1218-L1219",
        "symbol": "QuerySet.alatest"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "06ae5eee-7961-4c9f-ab69-161db1e8d879",
  "subject_name": "django/db/models/query::QuerySet.alatest",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def alatest(self, *fields)"
}
```

# Fact c9589488

Store id: 329e3491-97c4-482c-ae09-a948c8ea4c5e

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
- posted_at: `2026-11-09T23:32:04.4451840+00:00`

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
  "id": "329e3491-97c4-482c-ae09-a948c8ea4c5e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4451840+00:00"
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
  "subject_id": "5cd9aa9b-43b8-44e3-93be-658101c44687",
  "subject_name": "django/db/models/query::QuerySet.alatest",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def alatest(self, *fields)"
}
```

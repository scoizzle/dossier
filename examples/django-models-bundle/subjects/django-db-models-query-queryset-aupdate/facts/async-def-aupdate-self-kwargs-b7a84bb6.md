# Fact b7a84bb6

Store id: c2c21677-5255-4d81-8518-abefa6d548e9

## Text

```text
async def aupdate(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.5313250+00:00`

## Data

```json
{
  "end_line": 1453,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1452,
  "symbol": "QuerySet.aupdate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1452,"selector":"L1452-L1453","symbol":"QuerySet.aupdate"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aupdate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1453,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1452,
    "symbol": "QuerySet.aupdate"
  },
  "id": "c2c21677-5255-4d81-8518-abefa6d548e9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5313250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1452,
        "selector": "L1452-L1453",
        "symbol": "QuerySet.aupdate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e025a7d6-694b-4043-9a0e-4a6fcbc8ac99",
  "subject_name": "django/db/models/query::QuerySet.aupdate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate(self, **kwargs)"
}
```

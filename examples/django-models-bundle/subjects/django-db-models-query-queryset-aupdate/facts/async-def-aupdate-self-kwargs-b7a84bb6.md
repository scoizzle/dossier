# Fact b7a84bb6

Store id: b55fbeb5-374c-4e3b-9186-9f1b7a11397e

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
- posted_at: `2026-11-09T23:32:04.4862400+00:00`

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
  "id": "b55fbeb5-374c-4e3b-9186-9f1b7a11397e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4862400+00:00"
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
  "subject_id": "0d37d6dd-e1cf-4f96-9024-c866f92a5550",
  "subject_name": "django/db/models/query::QuerySet.aupdate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate(self, **kwargs)"
}
```

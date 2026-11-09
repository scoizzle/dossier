# Fact b7a84bb6

Store id: 69480e72-f355-4ef5-8fa0-b12ed14af717

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
- posted_at: `2026-11-09T23:44:55.9848290+00:00`

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
  "id": "69480e72-f355-4ef5-8fa0-b12ed14af717",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9848290+00:00"
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
  "subject_id": "29befad7-4a7e-4079-a237-ab2efca1371e",
  "subject_name": "django/db/models/query::QuerySet.aupdate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate(self, **kwargs)"
}
```

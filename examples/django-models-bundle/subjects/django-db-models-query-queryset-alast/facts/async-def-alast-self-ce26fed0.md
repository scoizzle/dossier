# Fact ce26fed0

Store id: 9d772060-6635-4f36-a07d-42f842914aee

## Text

```text
async def alast(self)
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
- posted_at: `2026-11-09T23:32:04.4589490+00:00`

## Data

```json
{
  "end_line": 1245,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1244,
  "symbol": "QuerySet.alast"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1244,"selector":"L1244-L1245","symbol":"QuerySet.alast"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.alast](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1245,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1244,
    "symbol": "QuerySet.alast"
  },
  "id": "9d772060-6635-4f36-a07d-42f842914aee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4589490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1244,
        "selector": "L1244-L1245",
        "symbol": "QuerySet.alast"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "63e2cdf5-0121-4d0b-ab64-06dceca2c06d",
  "subject_name": "django/db/models/query::QuerySet.alast",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def alast(self)"
}
```

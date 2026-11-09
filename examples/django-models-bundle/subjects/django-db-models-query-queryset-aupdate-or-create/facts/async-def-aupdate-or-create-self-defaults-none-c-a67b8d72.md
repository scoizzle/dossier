# Fact a67b8d72

Store id: ff862538-dedc-47ff-abbc-a4f0cc267884

## Text

```text
async def aupdate_or_create(self, defaults=None, create_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:55.9329870+00:00`

## Data

```json
{
  "end_line": 1148,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1143,
  "symbol": "QuerySet.aupdate_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1143,"selector":"L1143-L1148","symbol":"QuerySet.aupdate_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aupdate_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1148,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1143,
    "symbol": "QuerySet.aupdate_or_create"
  },
  "id": "ff862538-dedc-47ff-abbc-a4f0cc267884",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9329870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1143,
        "selector": "L1143-L1148",
        "symbol": "QuerySet.aupdate_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f51880a6-7470-48ff-973b-44fcce48b81e",
  "subject_name": "django/db/models/query::QuerySet.aupdate_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate_or_create(self, defaults=None, create_defaults=None, **kwargs)"
}
```

# Fact a67b8d72

Store id: 032a2397-b8b4-40c3-a91d-6226a86b1dc6

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
- posted_at: `2026-11-09T22:39:49.4527630+00:00`

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
  "id": "032a2397-b8b4-40c3-a91d-6226a86b1dc6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4527630+00:00"
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
  "subject_id": "9120e00a-9661-42a3-a8bf-e764bccfb5cd",
  "subject_name": "django/db/models/query::QuerySet.aupdate_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aupdate_or_create(self, defaults=None, create_defaults=None, **kwargs)"
}
```

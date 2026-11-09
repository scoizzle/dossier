# Fact 1a014633

Store id: 8a8d1fad-0896-49d9-a0ea-6078763e8659

## Text

```text
async def aaggregate(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.3733100+00:00`

## Data

```json
{
  "end_line": 680,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 679,
  "symbol": "QuerySet.aaggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":679,"selector":"L679-L680","symbol":"QuerySet.aaggregate"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aaggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 680,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 679,
    "symbol": "QuerySet.aaggregate"
  },
  "id": "8a8d1fad-0896-49d9-a0ea-6078763e8659",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3733100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 679,
        "selector": "L679-L680",
        "symbol": "QuerySet.aaggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d03aa02b-05e2-417e-b5a3-207bea170c96",
  "subject_name": "django/db/models/query::QuerySet.aaggregate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aaggregate(self, *args, **kwargs)"
}
```

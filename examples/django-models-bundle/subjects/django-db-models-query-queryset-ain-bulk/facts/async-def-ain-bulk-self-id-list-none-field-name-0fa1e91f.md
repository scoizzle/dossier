# Fact 0fa1e91f

Store id: c13b0847-2554-4845-95a1-276868d640dd

## Text

```text
async def ain_bulk(self, id_list=None, *, field_name="pk")
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
- posted_at: `2026-11-09T23:44:55.9714610+00:00`

## Data

```json
{
  "end_line": 1356,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1352,
  "symbol": "QuerySet.ain_bulk"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1352,"selector":"L1352-L1356","symbol":"QuerySet.ain_bulk"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.ain_bulk](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1356,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1352,
    "symbol": "QuerySet.ain_bulk"
  },
  "id": "c13b0847-2554-4845-95a1-276868d640dd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9714610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1352,
        "selector": "L1352-L1356",
        "symbol": "QuerySet.ain_bulk"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "cdc6c052-e2c0-4fa3-aea2-969788994c73",
  "subject_name": "django/db/models/query::QuerySet.ain_bulk",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def ain_bulk(self, id_list=None, *, field_name=\"pk\")"
}
```

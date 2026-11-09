# Fact 0fa1e91f

Store id: 747b3ea4-3bee-42bc-a784-a695a3f475c9

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
- posted_at: `2026-11-09T22:39:49.5110690+00:00`

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
  "id": "747b3ea4-3bee-42bc-a784-a695a3f475c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5110690+00:00"
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
  "subject_id": "4f0bc477-e6b1-4837-8787-4cf210b6f226",
  "subject_name": "django/db/models/query::QuerySet.ain_bulk",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def ain_bulk(self, id_list=None, *, field_name=\"pk\")"
}
```

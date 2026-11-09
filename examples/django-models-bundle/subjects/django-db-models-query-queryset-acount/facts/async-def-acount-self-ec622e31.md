# Fact ec622e31

Store id: fc87d26a-b838-48ff-8b26-663c2af5cbf1

## Text

```text
async def acount(self)
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
- posted_at: `2026-11-09T22:39:49.3812320+00:00`

## Data

```json
{
  "end_line": 696,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 695,
  "symbol": "QuerySet.acount"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":695,"selector":"L695-L696","symbol":"QuerySet.acount"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.acount](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 696,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 695,
    "symbol": "QuerySet.acount"
  },
  "id": "fc87d26a-b838-48ff-8b26-663c2af5cbf1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3812320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 695,
        "selector": "L695-L696",
        "symbol": "QuerySet.acount"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3bab096d-c398-402f-b702-0456af97fd39",
  "subject_name": "django/db/models/query::QuerySet.acount",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acount(self)"
}
```

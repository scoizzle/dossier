# Fact 80ea1977

Store id: 6cc0e763-b976-4caf-b89f-13dfc5bef5cc

## Text

```text
async def aearliest(self, *fields)
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
- posted_at: `2026-11-09T22:39:49.4700940+00:00`

## Data

```json
{
  "end_line": 1207,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1206,
  "symbol": "QuerySet.aearliest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1206,"selector":"L1206-L1207","symbol":"QuerySet.aearliest"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aearliest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1207,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1206,
    "symbol": "QuerySet.aearliest"
  },
  "id": "6cc0e763-b976-4caf-b89f-13dfc5bef5cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4700940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1206,
        "selector": "L1206-L1207",
        "symbol": "QuerySet.aearliest"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "858cd9d2-a634-48b1-ab96-49163f5c2f7f",
  "subject_name": "django/db/models/query::QuerySet.aearliest",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aearliest(self, *fields)"
}
```

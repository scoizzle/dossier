# Fact 80ea1977

Store id: 0c87c57a-6e7e-423f-9519-769772c60654

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
- posted_at: `2026-11-09T23:32:04.4393140+00:00`

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
  "id": "0c87c57a-6e7e-423f-9519-769772c60654",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4393140+00:00"
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
  "subject_id": "4c0bf9c2-951c-4fd6-ab86-6e38a80eb747",
  "subject_name": "django/db/models/query::QuerySet.aearliest",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aearliest(self, *fields)"
}
```

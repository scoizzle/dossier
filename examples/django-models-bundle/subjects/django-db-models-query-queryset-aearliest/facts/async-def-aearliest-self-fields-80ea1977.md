# Fact 80ea1977

Store id: b64e5f7a-7330-4504-91f6-86e96faebad4

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
- posted_at: `2026-11-09T23:44:55.9428750+00:00`

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
  "id": "b64e5f7a-7330-4504-91f6-86e96faebad4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9428750+00:00"
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
  "subject_id": "2c3812a4-d3db-4cbf-aa7a-8f8bd6bf78e5",
  "subject_name": "django/db/models/query::QuerySet.aearliest",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aearliest(self, *fields)"
}
```

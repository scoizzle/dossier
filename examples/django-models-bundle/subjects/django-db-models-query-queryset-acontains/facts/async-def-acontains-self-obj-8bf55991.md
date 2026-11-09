# Fact 8bf55991

Store id: bc6b40aa-3e50-48ee-992a-d42ea92eec4a

## Text

```text
async def acontains(self, obj)
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
- posted_at: `2026-11-09T23:32:04.5019460+00:00`

## Data

```json
{
  "end_line": 1511,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1510,
  "symbol": "QuerySet.acontains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1510,"selector":"L1510-L1511","symbol":"QuerySet.acontains"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.acontains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1511,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1510,
    "symbol": "QuerySet.acontains"
  },
  "id": "bc6b40aa-3e50-48ee-992a-d42ea92eec4a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5019460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1510,
        "selector": "L1510-L1511",
        "symbol": "QuerySet.acontains"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5e20d358-5efb-4db7-860a-2e2272591817",
  "subject_name": "django/db/models/query::QuerySet.acontains",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acontains(self, obj)"
}
```

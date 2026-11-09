# Fact 8bf55991

Store id: ac9be1e9-7f36-4ea5-b80b-2ca982d4a78d

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
- posted_at: `2026-11-09T23:44:55.9988790+00:00`

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
  "id": "ac9be1e9-7f36-4ea5-b80b-2ca982d4a78d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9988790+00:00"
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
  "subject_id": "3e936f2c-5291-41a2-8bcc-cc6d7ecfd2cf",
  "subject_name": "django/db/models/query::QuerySet.acontains",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acontains(self, obj)"
}
```

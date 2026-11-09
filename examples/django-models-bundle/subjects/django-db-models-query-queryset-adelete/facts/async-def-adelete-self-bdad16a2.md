# Fact bdad16a2

Store id: a865382a-6b89-475a-857c-9ccfbab3412e

## Text

```text
async def adelete(self)
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
- posted_at: `2026-11-09T23:32:04.4769870+00:00`

## Data

```json
{
  "end_line": 1392,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1391,
  "symbol": "QuerySet.adelete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1391,"selector":"L1391-L1392","symbol":"QuerySet.adelete"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.adelete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1392,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1391,
    "symbol": "QuerySet.adelete"
  },
  "id": "a865382a-6b89-475a-857c-9ccfbab3412e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4769870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1391,
        "selector": "L1391-L1392",
        "symbol": "QuerySet.adelete"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "506bd23f-a936-46b3-ad03-8a7ae7e9afa6",
  "subject_name": "django/db/models/query::QuerySet.adelete",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def adelete(self)"
}
```
